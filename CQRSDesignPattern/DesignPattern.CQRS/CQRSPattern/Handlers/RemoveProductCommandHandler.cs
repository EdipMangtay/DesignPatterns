﻿using DesignPattern.CQRS.CQRSPattern.Command;
using DesignPattern.CQRS.DAL;
using System.Data.Common;
using System.Net.Mime;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class RemoveProductCommandHandler
    {
        private readonly Context _context;

        public RemoveProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(RemoveProductCommand command)
        {
            var values = _context.products.Find(command.Id);
            _context.products.Remove(values);
            _context.SaveChanges();
        }
    }
}
