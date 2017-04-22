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
    public interface IFooterService
    {
        void Add(Footer footer);
        void Update(Footer footer);
        void Delete(int footerID);

        IEnumerable<Footer> GetAll();
    }
    public class FooterService: IFooterService
    {
        IFooterRepository _footerRepository;
        IUnitOfWork _unitOfWork;

        public FooterService(IFooterRepository footerRepository, IUnitOfWork unitOfWork)
        {
            this._footerRepository = footerRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(Footer footer)
        {
            _footerRepository.Add(footer);
        }

        public void Delete(int footerID)
        {
            _footerRepository.Delete(footerID);
        }

        public IEnumerable<Footer> GetAll()
        {
            return _footerRepository.GetAll();
        }

        public void Update(Footer footer)
        {
            _footerRepository.Update(footer);
        }
    }
}
