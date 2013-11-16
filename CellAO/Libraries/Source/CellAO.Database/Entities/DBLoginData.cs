﻿#region License

// Copyright (c) 2005-2013, CellAO Team
// 
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:
// 
//     * Redistributions of source code must retain the above copyright notice, this list of conditions and the following disclaimer.
//     * Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.
//     * Neither the name of the CellAO Team nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
// A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR
// CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL,
// EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO,
// PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR
// PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF
// LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING
// NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
// SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
// Last modified: 2013-11-16 19:03

#endregion

namespace CellAO.Database.Dao
{
    #region Usings ...

    using System;

    #endregion

    /// <summary>
    /// Data object for Login data
    /// </summary>
    public class DBLoginData
    {
        #region Public Properties

        /// <summary>
        /// Account flags
        /// </summary>
        public int AccountFlags { get; set; }

        /// <summary>
        /// Number of allowed characters
        /// </summary>
        public int Allowed_Characters { get; set; }

        /// <summary>
        /// Date of account creation
        /// </summary>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// email address of the account
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Enabled Expansions (bitfield)
        /// </summary>
        public int Expansions { get; set; }

        /// <summary>
        /// Account owner first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Account flags 2
        /// </summary>
        public int Flags { get; set; }

        /// <summary>
        /// GameMaster level 
        /// </summary>
        public int GM { get; set; }

        /// <summary>
        /// Account id
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Account owner last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Password (hash)
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Account username
        /// </summary>
        public string Username { get; set; }

        #endregion
    }
}