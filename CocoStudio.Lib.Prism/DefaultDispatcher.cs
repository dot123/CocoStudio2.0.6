﻿// Decompiled with JetBrains decompiler
// Type: CocoStudio.Lib.Prism.DefaultDispatcher
// Assembly: CocoStudio.Lib.Prism, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 65DD164F-466A-4C92-9EBC-2D8FF1AF8D80
// Assembly location: C:\Program Files (x86)\Cocos\Cocos Studio 2\CocoStudio.Lib.Prism.dll

using Gtk;
using System;

namespace CocoStudio.Lib.Prism
{
  public class DefaultDispatcher : IDispatcherFacade
  {
    public void BeginInvoke(Delegate method, object arg)
    {
      Application.Invoke((EventHandler) ((param0, param1) => method.DynamicInvoke(arg)));
    }

    public void BeginInvoke(EventHandler method, EventArgs args)
    {
      throw new NotImplementedException();
    }
  }
}
