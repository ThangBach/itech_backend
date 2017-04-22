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
    public interface IOrderService
    {
        void Add(Order order);
        void Update(Order order);
        void Delete(int orderID);
        IEnumerable<Order> GetAll();
    }
    public class OrderService: IOrderService
    {
        IOrderRepository _orderRepository;
        IUnitOfWork _unitOfWork;

        public OrderService(IOrderRepository orderRepository, IUnitOfWork unitOfWork)
        {
            this._orderRepository = orderRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(Order order)
        {
            _orderRepository.Add(order);
        }

        public void Delete(int orderID)
        {
            _orderRepository.Delete(orderID);
        }

        public IEnumerable<Order> GetAll()
        {
            return _orderRepository.GetAll();
        }

        public void Update(Order order)
        {
             _orderRepository.Update(order);
        }
    }
}
