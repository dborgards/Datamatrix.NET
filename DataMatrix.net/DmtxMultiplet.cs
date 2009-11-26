﻿/*
DataMatrix.Net

DataMatrix.Net - .net library for decoding DataMatrix codes.
Copyright (C) 2009 Michael Faschinger

This library is free software; you can redistribute it and/or
modify it under the terms of the GNU General Public
License as published by the Free Software Foundation; either
version 3.0 of the License, or (at your option) any later version.

This library is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
Lesser General Public License for more details.

You should have received a copy of the GNU General Public
License along with this library; if not, write to the Free Software
Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301  USA

Contact: Michael Faschinger - michfasch@gmx.at
 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataMatrix.net
{
    internal struct DmtxTriplet
    {
        byte[] _value;

        internal byte[] Value
        {
            get
            {
                if (_value == null)
                {
                    _value = new byte[3];
                }
                return _value;
            }
        }
    }

    /**
     * @struct DmtxQuadruplet
     * @brief DmtxQuadruplet
     */
    internal struct DmtxQuadruplet
    {
        byte[] _value;

        internal byte[] Value
        {
            get
            {
                if (_value == null)
                {
                    _value = new byte[4];
                }
                return _value;
            }
        }
    }
}