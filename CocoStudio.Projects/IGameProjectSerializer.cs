﻿// Decompiled with JetBrains decompiler
// Type: CocoStudio.Projects.IGameProjectSerializer
// Assembly: CocoStudio.Projects, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DCF182CC-57DB-4DD6-AF38-C89A798411CC
// Assembly location: C:\Program Files (x86)\Cocos\Cocos Studio 2\CocoStudio.Projects.dll

using Mono.Addins;

namespace CocoStudio.Projects
{
  [TypeExtensionPoint]
  public interface IGameProjectSerializer
  {
    string ID { get; }

    string Label { get; }

    string Serialize(PublishInfo info, IProjectFile projFile);
  }
}
