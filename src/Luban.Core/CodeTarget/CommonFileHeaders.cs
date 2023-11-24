namespace Luban.CodeTarget;

public class CommonFileHeaders
{
    public const string AUTO_GENERATE_C_LIKE = @"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
";


    public const string AUTO_GENERATE_LUA = @"
--[[------------------------------------------------------------------------------
-- <auto-generated>
--     This code was generated by a tool.
--     Changes to this file may cause incorrect behavior and will be lost if
--     the code is regenerated.
-- </auto-generated>
--]]------------------------------------------------------------------------------
";

    public const string AUTO_GENERATE_PYTHON = @"
#-*- coding: utf-8 -*-
'''
  <auto-generated>
    This code was generated by a tool.
    Changes to this file may cause incorrect behavior and will be lost if
    the code is regenerated.
  </auto-generated>
'''
";

    public const string AUTO_GENERATE_GDSCRIPT = @"
#  <auto-generated>
#    This code was generated by a tool.
#    Changes to this file may cause incorrect behavior and will be lost if
#    the code is regenerated.
#  </auto-generated>
";
}
