// Copyright 2025 Code Philosophy
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

﻿using Luban.Defs;

namespace Luban.DataLoader;

public class DataCreateException : System.Exception
{
    private List<(DefBean, DefField)> VariablePath { get; } = new();

    public string OriginDataLocation { get; set; }

    public string DataLocationInFile { get; }

    public string OriginErrorMsg { get; }

    public string OriginStackTrace { get; }

    public DataCreateException(Exception e, string dataLocation) : base(e.Message, e)
    {
        this.OriginStackTrace = e.StackTrace;
        this.OriginErrorMsg = e.Message;
        this.DataLocationInFile = dataLocation;
    }

    public override string Message => this.OriginErrorMsg;

    public void Push(DefBean bean, DefField f)
    {
        VariablePath.Add((bean, f));
    }

    public string VariableFullPathStr
    {
        get
        {
            var path = new List<(DefBean, DefField)>(VariablePath);
            path.Reverse();
            return string.Join(" => ", path.Select(b => $"{{{b.Item1.FullName}}}.{b.Item2.Name}"));
        }
    }
}
