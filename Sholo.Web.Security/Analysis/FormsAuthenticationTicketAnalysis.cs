/*
 * Copyright 2010-2012, Scott Holodak, Alex Friedman
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
using System.Web.Security;
using Sholo.Web.Security.Authentication.User;

namespace Sholo.Web.Security.Analysis
{
    /// <summary>
    /// Analysis results of the FormsAuthenticationTicket validity & security
    /// </summary>
    [Serializable]
    public sealed class FormsAuthenticationTicketAnalysis
    {
        private UserAuthenticationTicket _userAuthenticationTicket;

        /// <summary>
        /// The FormsAuthenticationTicket to validate
        /// </summary>
        public FormsAuthenticationTicket FormsAuthenticationTicket { get; internal set; }

        /// <summary>
        /// Indicates whether the FormsAuthenticationTicket exists
        /// </summary>
        public bool TicketExists { get; internal set; }
            
        /// <summary>
        /// Indicates whether or not the FormsAuthenticationTicket is valid
        /// </summary>
        public bool IsValid { get; internal set; }
            
        /// <summary>
        /// Indicates whether or not the FormsAuthenticationTicket is malicious
        /// </summary>
        public bool IsMalicious { get; internal set; }

        /// <summary>
        /// The ServerKey embedded in the UserData of the FormsAuthenticationTicket
        /// </summary>
        public string ServerKey { get; internal set; }
            
        /// <summary>
        /// The Ticket hash embedded in the UserData of the FormsAuthenticationTicket
        /// </summary>
        public string TicketHash { get; internal set; }

        /// <summary>
        /// Indicates whether the CookiePath contained in the FormsAuthenticationTicket matches the CookiePath contained in the FormsAuthenticationCookie
        /// </summary>
        public bool CookiePathMatches { get; internal set; }
            
        /// <summary>
        /// Indicates whether the FormsAuthenticationTicket is expired
        /// </summary>
        public bool IsExpired { get; internal set; }
            
        /// <summary>
        /// Indicates whether the FormsAuthenticationTicket persistence is valid
        /// </summary>
        public bool IsPersistenceValid { get; internal set; }
            
        /// <summary>
        /// Indicates whether the FormsAuthenticationTicket IssueDate is valid
        /// </summary>
        public bool IsIssueDateValid { get; internal set; }
            
        /// <summary>
        /// Indicates whether the FormsAuthenticationTicket Name is valid
        /// </summary>
        public bool IsNameValid { get; internal set; }
            
        /// <summary>
        /// Indicates whether the FormsAuthenticationTicket has UserData
        /// </summary>
        public bool HasUserData { get; internal set; }
            
        /// <summary>
        /// Indicates whether the FormsAuthenticationTicket UserData contains a hash
        /// </summary>
        public bool UserDataContainsHash { get; set; }
            
        /// <summary>
        /// Indicates whether the FormsAuthenticationTicket UserData hash is valid
        /// </summary>
        public bool IsUserDataHashValid { get; set; }
            
        /// <summary>
        /// Indicates whether the FormsAuthenticationTicket UserData contains a UserAuthenticationTicket key
        /// </summary>
        public bool UserDataContainsServerAuthenticationTicketKey { get; internal set; }
            
        /// <summary>
        /// Indicates whether the FormsAuthenticationTicket UserData UserAuthenticationTicket exists in the ticket store
        /// </summary>
        public bool UserDataServerAuthenticationTicketKeyFound { get; internal set; }
            
        /// <summary>
        /// Indicates whether the FormsAuthenticationTicket Version is valid
        /// </summary>
        public bool IsVersionValid { get; internal set; }

        /// <summary>
        /// Retrieves the UserAuthenticationTicket referenced by the FormsAuthenticationTicket
        /// </summary>
        /// <returns>The UserAuthenticationTicket referenced by the FormsAuthenticationTicket</returns>
        public UserAuthenticationTicket GetServerAuthenticationTicket()
        {
            return _userAuthenticationTicket;
        }

        internal void SetServerAuthenticationTicket(UserAuthenticationTicket userAuthenticationTicket)
        {
            _userAuthenticationTicket = userAuthenticationTicket;
        }
    }
}