﻿// Decompiled with JetBrains decompiler
// Type: CocoStudio.Model.Interface.InputDispatchHandler`1
// Assembly: CocoStudio.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9A645332-034C-44D3-9062-5E94EDCB75FF
// Assembly location: C:\Program Files (x86)\Cocos\Cocos Studio 2\CocoStudio.Model.dll

using CocoStudio.Model.ViewModel;
using System;
using System.Collections.Generic;

namespace CocoStudio.Model.Interface
{
  public delegate void InputDispatchHandler<T>(T args, IEnumerable<VisualObject> selectedParentObject) where T : EventArgs;
}
