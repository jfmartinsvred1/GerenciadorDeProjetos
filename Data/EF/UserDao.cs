﻿using AutoMapper;
using Gerenciador.Dtos;
using Gerenciador.Models;
using Gerenciador.Services;
using Microsoft.AspNetCore.Identity;

namespace Gerenciador.Data.EF
{
    public class UserDao : IUserDao
    {
        IMapper _mapper;
        UserManager<User> _userManager;
        SignInManager<User> _signInManager;
        TokenService _tokenService;
        EmailService _emailService;

        public UserDao(IMapper mapper, UserManager<User> manager, SignInManager<User> signInManager, TokenService tokenService, EmailService emailService)
        {
            _mapper = mapper;
            _userManager = manager;
            _signInManager = signInManager;
            _tokenService = tokenService;
            _emailService = emailService;
        }

        public async Task<string> LoginUser(LoginUserDto dto)
        {
            var resultado = await _signInManager.PasswordSignInAsync(dto.Username,dto.Password,false,false);

            if(resultado.Succeeded==false)
            {
                throw new ApplicationException("Algo deu errado!");
            }

            var user = _signInManager
                .UserManager
                .Users
                .FirstOrDefault(user=>user.NormalizedUserName ==dto.Username.ToUpper());

            var token = _tokenService.GenerateToken(user);

            return token;
        }

        public async Task RegisterUser(CreateUserDto dto)
        {
            User user = _mapper.Map<User>(dto);
            IdentityResult result = await _userManager.CreateAsync(user,dto.Password);
            if(!result.Succeeded)
            {
                throw new ApplicationException("Algo Deu Errado!");
            }
            var code = Email.SendEmailConfirmation(dto.Email);

            _emailService.SaveCode(code,dto.Email);

        }
    }
}
