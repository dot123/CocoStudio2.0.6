﻿// Decompiled with JetBrains decompiler
// Type: CocoStudio.Core.ExtensionModel.IMainWindowPart
// Assembly: CocoStudio.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 664CC19D-01B7-42F7-9640-243AA07066CE
// Assembly location: C:\Program Files (x86)\Cocos\Cocos Studio 2\CocoStudio.Core.dll

using Mono.Addins;

namespace CocoStudio.Core.ExtensionModel
{
  [TypeExtensionPoint(Path = "/CocoStudio/Ide/MainStatus")]
  [TypeExtensionPoint(Path = "/CocoStudio/Ide/MainMenuBar")]
  [TypeExtensionPoint(Path = "/CocoStudio/Ide/MainStartPage")]
  public interface IMainWindowPart
  {
  }
}