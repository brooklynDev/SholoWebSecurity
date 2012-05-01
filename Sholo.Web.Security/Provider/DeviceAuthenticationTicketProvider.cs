﻿/*
 * Copyright 2010-2012, Scott Holodak
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Configuration.Provider;
using Sholo.Web.Security.State;
using Sholo.Web.Security.Ticket;

namespace Sholo.Web.Security.Provider
{
    public abstract class DeviceAuthenticationTicketProvider : ProviderBase, IDeviceAuthenticationTicketStore
    {
        public abstract void Initialize();
        public abstract void RemoveExpiredTickets();
        public abstract DeviceAuthenticationTicket GetTicket(string ticketKey);
        public abstract void InsertTicket(DeviceAuthenticationTicket ticket, DateTime expiration);
        public abstract void UpdateTicketExpiration(DeviceAuthenticationTicket ticket, DateTime newExpiration);
        public abstract void RevokeTicket(string ticketKey);
        public abstract bool ContainsTicket(string ticketKey);
        public abstract IEnumerable<DeviceAuthenticationTicket> GetAllTickets();
        public abstract IEnumerable<string> GetAllTicketKeys();
        public abstract bool VerifyTicket(DeviceAuthenticationTicket ticket);
    }
}
