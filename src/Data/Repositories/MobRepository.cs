﻿// <auto-generated />
//-----------------------------------------------------------------------------
// <copyright file="MobRepository.cs" company="WheelMUD Development Team">
//   Copyright (c) WheelMUD Development Team. See LICENSE.txt. This file is
//   subject to the Microsoft Public License. All other rights reserved.
// </copyright>
// <summary>
//   auto-generated by Repository.cst on 4/9/2013 4:29:50 PM
// </summary>
//-----------------------------------------------------------------------------

namespace WheelMUD.Data.Repositories
{
    using System.Collections.Generic;
    using System.Data;
    using ServiceStack.OrmLite;
    using WheelMUD.Data.Entities;
    
    ///<summary>
    /// Repository for the Mobs table.
    ///</summary>
    public partial class MobRepository : IMobRepository
    {		
        #region IMobRepository Members

        public void Add(MobRecord mob)
        {
            using (IDbCommand session = Helpers.OpenSession())
                using (IDbTransaction transaction = session.Connection.BeginTransaction())
                {
                    session.Connection.Save(mob);
                    transaction.Commit();
                }
        }

        public void Update(MobRecord mob)
        {
            using (IDbCommand session = Helpers.OpenSession())
                using (IDbTransaction transaction = session.Connection.BeginTransaction())
                {
                    session.Connection.Update(mob);
                    transaction.Commit();
                }
        }

        public void Remove(MobRecord mob)
        {
            using (IDbCommand session = Helpers.OpenSession())
                using (IDbTransaction transaction = session.Connection.BeginTransaction())
                {
                    session.Connection.Delete(mob);
                    transaction.Commit();
                }
        }
        
        public MobRecord GetById(long mobId)
        {
            using (IDbCommand session = Helpers.OpenSession())
                return session.Connection.SingleWhere<MobRecord>("ID = {0}", mobId);
        }		

        public MobRecord GetByName(string name)
        {
            using (IDbCommand session = Helpers.OpenSession())
            {
                return session.Connection.SingleWhere<MobRecord>("Name = {0}", name);
            }
        }

        public ICollection<MobRecord> FetchAll()
        {
            using (IDbCommand session = Helpers.OpenSession())
            {
                return session.Connection.Select<MobRecord>();
            }
        }

        #endregion
    }
}