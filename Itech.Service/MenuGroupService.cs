using Itech.Data.Infrastructure;
using Itech.Data.Repositories;
using Itech.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itech.Service
{
    public interface IMenuGroupService
    {
        void Add(MenuGroup menuGroup);
        void Update(MenuGroup menuGroup);
        void Delete(int menuGroupID);
        IEnumerable<MenuGroup> GetAll();
    }
    public class MenuGroupService: IMenuGroupService
    {
        IMenuGroupRepository _menuGroupRepository;
        IUnitOfWork _unitOfWork;

        public MenuGroupService(IMenuGroupRepository menuGroupRepository, IUnitOfWork unitOfWork)
        {
            this._menuGroupRepository = menuGroupRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(MenuGroup menuGroup)
        {
            _menuGroupRepository.Add(menuGroup);
        }

        public void Delete(int menuGroupID)
        {
            _menuGroupRepository.Delete(menuGroupID);
        }

        public IEnumerable<MenuGroup> GetAll()
        {
            return _menuGroupRepository.GetAll();
        }

        public void Update(MenuGroup menuGroup)
        {
            _menuGroupRepository.Update(menuGroup);
        }
    }
}
