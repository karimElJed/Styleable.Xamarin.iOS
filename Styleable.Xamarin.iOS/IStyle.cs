﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Styleable.Xamarin.iOS
{
    //todo: document
    /// <summary>
    /// Helper interface .. 
    /// </summary>
    /// <typeparam name="TView"></typeparam>
    public interface IStyle<out TView> where TView : IStyleable
    {
        
    }
}