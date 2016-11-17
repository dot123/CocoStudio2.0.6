﻿// Decompiled with JetBrains decompiler
// Type: CocoStudio.Model.ViewModel.EnumTypeAttribute
// Assembly: CocoStudio.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9A645332-034C-44D3-9062-5E94EDCB75FF
// Assembly location: C:\Program Files (x86)\Cocos\Cocos Studio 2\CocoStudio.Model.dll

using System;

namespace CocoStudio.Model.ViewModel
{
  [AttributeUsage(AttributeTargets.Field, AllowMultiple = true, Inherited = false)]
  public class EnumTypeAttribute : Attribute
  {
    private string description;

    public string Description
    {
      get
      {
        return this.description;
      }
    }

    public EnumTypeAttribute(string Description_in)
    {
      this.description = Description_in;
    }
  }
}
