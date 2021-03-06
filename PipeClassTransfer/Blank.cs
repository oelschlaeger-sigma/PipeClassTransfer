﻿// This file Head.cs is part of PipeClassTransfer
// Copyright (C) 2020 SIGMA Ingenieurgesellschaft mbH, Unna, Germany
// 
// PipeClassTransfer is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// PipeClassTransfer is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public License
// along with PipeClassTransfer.  If not, see <http://www.gnu.org/licenses/>.

namespace PipeClassTransfer
{
    /// <summary>
    /// Contains data for blanks
    /// </summary>
    public class Blank : Pipe
    {
        /// <summary>
        /// Nominal diameter of the blank
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public double DN { get; set; }
        /// <summary>
        /// Nominal pressure
        /// </summary>
        [System.Xml.Serialization.XmlAttribute]
        public double PN { get; set; }

    }
}