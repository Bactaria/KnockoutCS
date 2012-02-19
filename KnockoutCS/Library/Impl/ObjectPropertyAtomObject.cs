/**********************************************************************
 * 
 * Update Controls .NET
 * Copyright 2010 Michael L Perry
 * MIT License
 * 
 * http://updatecontrols.net
 * http://updatecontrols.codeplex.com/
 * 
 **********************************************************************/

using System;

namespace KnockoutCS.Library.Impl
{
    class ObjectPropertyAtomObject : ObjectPropertyAtom
    {
        public ObjectPropertyAtomObject(IObjectInstance objectInstance, ClassProperty classProperty)
            : base(objectInstance, classProperty)
        {
        }

        public override object TranslateIncommingValue(object value)
        {
            return value == null ? null : ((IObjectInstance)value).WrappedObject;
        }

        public override object TranslateOutgoingValue(object value)
        {
            return value == null ? null : WrapObject(value);
        }
    }
}
