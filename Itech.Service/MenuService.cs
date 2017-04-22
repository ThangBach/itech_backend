using Itech.Data.Infrastructure;
using Itech.Data.Repositories;
using Itech.Model.Models;
using System.Collections.Generic;
using System;

namespace Itech.Service
{
    public interface IMenuService
    {
        void Add(Menu menu);

        void Update(Menu menu);

        void Delete(int menuID);

        IEnumerable<Menu> GetAll();
    }

    public class MenuService : IMenuService
    {
        IMenuRepository _menuRepository;
        IUnitOfWork _unitOfWork;

        public MenuService(IMenuRepository menuRepository, IUnitOfWork unitOfWork)
        {
            this._menuRepository = menuRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(Menu menu)
        {
            _menuRepository.Add(menu);
        }

        public void Delete(int menuID)
        {
            _menuRepository.Delete(menuID);
        }

        public IEnumerable<Menu> GetAll()
        {
            return _menuRepository.GetAll();
        }

        public void Update(Menu menu)
        {
            _menuRepository.Update(menu);
        }
    }
}