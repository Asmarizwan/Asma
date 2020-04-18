using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mvc2Hockey.Models;
using Mvc2Hockey.ViewModels;

namespace Mvc2Hockey.Controllers
{
    public class PlayerController : Controller
    {
        private IPlayerRepository _playerRepository;
        public PlayerController(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }
        public IActionResult Index()
        {
           var viewModel= _playerRepository.GetAll().Select(p => new PlayerListViewModel { Name = p.Name, Id = p.Id }).ToList();
            return View(viewModel);
        }
        public IActionResult PlayerDetail(int id)
        {
            var player = _playerRepository.Get(id);
            var viewModel = new PlayerViewModel { Name = player.Name, JerseyNumber = player.JerseyNumber };
            return View(viewModel);
        }
    } 
}