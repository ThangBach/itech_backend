using Itech.Data.Infrastructure;
using Itech.Data.Repositories;
using Itech.Model.Models;
using System;
using System.Collections.Generic;

namespace Itech.Service
{
    public interface IMemberCategoryService
    {
        void Add(MemberCategory memberCategory);

        void Update(MemberCategory memberCategory);

        void Delete(int memberCategoryID);

        IEnumerable<MemberCategory> GetAll();
    }

    public class MemberCategoryService : IMemberCategoryService
    {
        IMemberCategoryRepository _memberCategoryRepository;
        IUnitOfWork _unitOfWork;

        public MemberCategoryService(IMemberCategoryRepository memberCategoryRepository, IUnitOfWork unitOfWork)
        {
            this._memberCategoryRepository = memberCategoryRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(MemberCategory memberCategory)
        {
            _memberCategoryRepository.Add(memberCategory);
        }

        public void Delete(int memberCategoryID)
        {
            _memberCategoryRepository.Delete(memberCategoryID);
        }

        public IEnumerable<MemberCategory> GetAll()
        {
            return _memberCategoryRepository.GetAll(new string[] { "Members" });
        }

        public void Update(MemberCategory memberCategory)
        {
            _memberCategoryRepository.Update(memberCategory);
        }
    }
}