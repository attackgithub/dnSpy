﻿/*
    Copyright (C) 2014-2018 de4dot@gmail.com

    This file is part of dnSpy

    dnSpy is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    dnSpy is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with dnSpy.  If not, see <http://www.gnu.org/licenses/>.
*/

using System.Collections.Generic;
using System.Linq;
using dnSpy.Scripting.Roslyn.Properties;

namespace dnSpy.Scripting.Roslyn.Common {
	sealed class ResetCommand : IScriptCommand {
		public IEnumerable<string> Names {
			get { yield return "reset"; }
		}

		public string ShortDescription => dnSpy_Scripting_Roslyn_Resources.HelpResetDescription;

		public void Execute(ScriptControlVM vm, string[] args) {
			bool noconfig = args.Any(a => a == "noconfig");
			vm.Reset(!noconfig);
		}
	}
}
