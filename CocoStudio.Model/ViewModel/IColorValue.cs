﻿// Decompiled with JetBrains decompiler
// Type: CocoStudio.Model.ViewModel.IColorValue
// Assembly: CocoStudio.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9A645332-034C-44D3-9062-5E94EDCB75FF
// Assembly location: C:\Program Files (x86)\Cocos\Cocos Studio 2\CocoStudio.Model.dll

using System.Drawing;

namespace CocoStudio.Model.ViewModel
{
  internal interface IColorValue
  {
    int ComboBoxIndex { get; set; }

    Color EndColor { get; set; }

    Color FirstColor { get; set; }

    Color SingleColor { get; set; }

    ScaleValue ColorVector { get; set; }
  }
}
