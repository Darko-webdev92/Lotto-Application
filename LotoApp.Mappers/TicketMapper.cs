﻿using LotoApp.DomainModels;
using LotoApp.InterfaceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotoApp.Mappers
{
    public static class TicketMapper
    {
        public static TicketDto ToTicketDto(Ticket ticket, string userId, Draw session)
        {
            return new TicketDto
            {
                Number_1 = ticket.Number_1,
                Number_2 = ticket.Number_2,
                Number_3 = ticket.Number_3,
                Number_4 = ticket.Number_4,
                Number_5 = ticket.Number_5,
                Number_6 = ticket.Number_6,
                Number_7 = ticket.Number_7,
                TicketPurchased = ticket.TicketPurchased,
                UserId = userId,
                Session = session.Id
            };
        }

        public static Ticket ToTicket()
        {
            return new Ticket
            {

            };
        }
    }
}
