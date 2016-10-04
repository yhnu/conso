﻿using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace BluConsole
{

[Serializable]
public class LogInfo
{

    [SerializeField] private Guid _identifier;
    [SerializeField] private string _rawMessage;
    [SerializeField] private string _message;
    [SerializeField] private List<LogStackFrame> _callStack;
    [SerializeField] private BluLogType _logType;
    [SerializeField] private bool _isCompilerError;

    public Guid Identifier
    {
        get
        {
            return _identifier;
        }
    }

    public string RawMessage
    {
        get
        {
            return _rawMessage;
        }
    }

    public string Message
    {
        get
        {
            return _message;
        }
    }

    public List<LogStackFrame> CallStack
    {
        get
        {
            return _callStack;
        }
    }

    public BluLogType LogType
    {
        get
        {
            return _logType;
        }
    }

    public bool IsCompilerError
    {
        get
        {
            return _isCompilerError;
        }
    }

    public LogInfo(string rawMessage,
                   string message,
                   List<LogStackFrame> callStack,
                   BluLogType logType,
                   bool isCompilerError)
    {
        _identifier = Guid.NewGuid();
        _rawMessage = rawMessage;
        _message = message;
        _callStack = callStack;
        _logType = logType;
        _isCompilerError = isCompilerError;
    }

}

}
