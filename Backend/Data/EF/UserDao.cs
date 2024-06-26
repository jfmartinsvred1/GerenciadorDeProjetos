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
        GerenciadorContext _context;
        IProjectUserDao _projectUserDao;

        public UserDao(IMapper mapper, UserManager<User> manager, SignInManager<User> signInManager, TokenService tokenService, EmailService emailService, GerenciadorContext context, IProjectUserDao projectUserDao)
        {
            _mapper = mapper;
            _userManager = manager;
            _signInManager = signInManager;
            _tokenService = tokenService;
            _emailService = emailService;
            _context = context;
            _projectUserDao = projectUserDao;
        }

        public ICollection<ReadUsersDto> GetUsersIds(string projectId)
        {
            var ids = _projectUserDao.GetAllIdsOfProject(projectId);

            var users = new List<User>();
            foreach (var id in ids)
            {
                var user = _signInManager.UserManager.Users.FirstOrDefault(x => x.Id == id);
                users.Add(user);
            }
            return _mapper.Map<List<ReadUsersDto>>(users);
        }

        public async Task<string> LoginUser(LoginUserDto dto)
        {
            var resultado = await _signInManager.PasswordSignInAsync(dto.Username,dto.Password,false,false);

            if(resultado.Succeeded==false)
            {
                //throw new ApplicationException("Algo deu errado!");
                return "AlgoDeuErrado";
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

        public void VerifyEmail(VerifyEmail verify)
        {
            var resp = _emailService.VerifyCode(verify.Code,verify.Email);
            if (!resp)
            {
                throw new ApplicationException("Algo Deu Errado");
            }
            var user = _signInManager
                .UserManager
                .Users
                .FirstOrDefault(user => user.NormalizedUserName == verify.Username.ToUpper());

            user.EmailConfirmed = true;

            _context.Users.Update(user);
            _context.SaveChanges();
        }
    }
}
