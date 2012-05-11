/*
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

using Sholo.Web.Security.Ticket;

namespace Sholo.Web.Security.Authentication.Device
{
    /// <summary>
    /// 
    /// </summary>
    public class DeviceAuthenticationTicket : BaseAuthenticationTicket
    {
        /// <summary>
        /// The User-Agent of the device who initially received the
        /// DeviceAuthenticationTicket
        /// </summary>
        public string UserAgent { get; set; }

        /// <summary>
        /// The HostAddress of the device that initially received the
        /// DeviceAuthenticationTicket
        /// </summary>
        public string HostAddress { get; set; }
    }
}