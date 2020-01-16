using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Internal;
using RappelzCore.Repositories.Interfaces;

namespace RappelzCore.Repositories
{
    public class Block : IEntity
    {
        public int Id { get; set; }
        public int BlockId { get; set; } //[Auth].[block].id
        public string Account { get; set; } //[Auth].[block].account
        public int AccountId { get; set; } //[Auth].[block].account_id
        public DateTime Date { get; set; } //[Auth].[block].date
        public DateTime UnbanDate { get; set; } //[Auth].[block].unban_date
        public string BanOwner { get; set; } //[Auth].[block].ban_owner
        public string BanDisc { get; set; } //[Auth].[block].ban_disc
        public int TypeBlock { get; set; } //[Auth].[block].typeblock

        /* Database [Auth]
         * CREATE TABLE [dbo].[block](
	            [id] [int] IDENTITY(1,1) NOT NULL,
	            [account] [varchar](50) NOT NULL,
	            [account_id] [int] NOT NULL,
	            [date] [datetime] NOT NULL,
	            [unban_date] [datetime] NOT NULL,
	            [ban_owner] [varchar](50) NOT NULL,
	            [ban_disc] [varchar](max) NOT NULL,
	            [typeBlock] [int] NOT NULL,
         */

        public Block()
        {
        }
    }
}
