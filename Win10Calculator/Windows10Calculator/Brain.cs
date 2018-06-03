using System;
using System.IO;
using System.Xml.Serialization;

namespace Windows10Calculator
{
    public delegate void MyDelegate(string msg);
    enum State
    {
        Zero,
        Accumulate,
        Accumulate2,
        AccumulateWithDecimal,
        ComputeP,
        ComputeNoP,
        Error
    }

    enum Operations
    {
        Plus,
        Minus,
        Multiply,
        Divide
    }

    public class Brain
    {
        public MyDelegate invoker;
        State CurrentState;
        Operations WhatToDo;

        public Brain()
        {
            CurrentState = State.Zero;
        }

        string currentN = "";
        string saved = "";
        double firstN;
        double N;

        string all = "0123456789";
        string non_zero = "123456789";
        string zero = "0";
        string comma = ",";
        string op = "+−×÷";
        string equals = "=";
        string extrabutton = "√±%";
        string square = " x²";
        string inverse = "⅟";
        string backspace = "⌫";
        string c = "C";
        string ce = "CE";
        string ms = "MS";
        string mr = "MR";
        string mc = "MC";

        public void Process(string operation)
        {
            switch (CurrentState)   
            {
                case State.Zero:
                    Zero(false, operation);
                    break;
                case State.Accumulate:
                    Accumulate(false, operation);
                    break;
                case State.Accumulate2:
                    Accumulate2(false, operation);
                    break;
                case State.ComputeP:
                    ComputeP(false, operation);
                    break;
                case State.ComputeNoP:
                    ComputeNoP(false, operation);
                    break;
                case State.Error:
                    Error(false, operation);
                    break;
                default:
                    break;
            }
        }

        public void Zero(bool isInput, string info)
        {
            if (isInput)
            {
                currentN = "";
                invoker.Invoke("0");
                CurrentState = State.Zero;
            }
            else
            {
                if (non_zero.Contains(info) || comma.Contains(info))
                {
                    Accumulate(true, info);
                }
                else if (zero.Contains(info))
                {
                    Zero(true, info);
                }
                else if (inverse.Contains(info))
                {
                    Error(true, info);
                }
                else if (ms.Contains(info))
                {
                    saved = "0";
                    Zero(true, info);
                }
                else if (mr.Contains(info) && saved != "")
                {
                    currentN = saved;
                    invoker.Invoke(currentN);
                    Accumulate(true, info);
                }
                else if (mc.Contains(info))
                {
                    saved = "";
                    Zero(true, info);
                }
            }
        }

        public void Accumulate(bool isInput, string info)
        {
            if (isInput)
            {
                if (comma.Contains(info) && currentN == "")
                {
                    currentN = "0,";
                }
                else if (comma.Contains(info) && !currentN.Contains(","))
                {
                    currentN += info;
                }
                else if (all.Contains(info))
                {
                    if (currentN == "0") currentN = info;
                    else currentN += info;
                }
                else if (mr.Contains(info))
                {
                    currentN = saved;
                }
                invoker.Invoke(currentN);
                CurrentState = State.Accumulate;
            }
            else
            {
                if (all.Contains(info) || (comma.Contains(info) && !currentN.Contains(",")))
                {
                    Accumulate(true, info);
                }
                else if (op.Contains(info))
                {
                    ComputeP(true, info);
                }
                else if (extrabutton.Contains(info))
                {
                    if (info == "√")
                    {
                        N = double.Parse(currentN);
                        if (N < 0) Error(true, info);
                        else
                        {
                            currentN = Math.Sqrt(N).ToString();
                            invoker.Invoke(currentN);
                        }
                    }
                    else
                    {
                        ExtraButton(info);
                        CurrentState = State.Accumulate;
                    }
                }
                else if (square.Contains(info))
                {
                    N = double.Parse(currentN);
                    currentN = (N * N).ToString();
                    invoker.Invoke(currentN);
                    CurrentState = State.Accumulate;
                }
                else if (inverse.Contains(info))
                {
                    N = double.Parse(currentN);
                    if (N == 0)
                    {
                        Error(true, info);
                    }
                    else
                    {
                        currentN = (1 / N).ToString();
                        invoker.Invoke(currentN);
                        CurrentState = State.Accumulate;
                    }
                }
                else if (backspace.Contains(info))
                {
                    if (currentN.Length == 1)
                    {
                        Zero(true, info);
                    }
                    else
                    {
                        currentN = currentN.Remove(currentN.Length - 1);
                        Accumulate(true, info);
                    }
                }
                else if (c.Contains(info) || ce.Contains(info))
                {
                    Zero(true, info);
                }
                else if (ms.Contains(info))
                {
                    saved = currentN;
                    Accumulate(true, info);
                }
                else if (mr.Contains(info) && saved != "")
                {
                    Accumulate(true, info);
                }
                else if (mc.Contains(info))
                {
                    saved = "";
                    Accumulate(true, info);
                }
            }
        }

        public void ComputeP(bool isInput, string info)
        {
            if (isInput)
            {
                if (currentN != "") firstN = double.Parse(currentN);
                currentN = "";
                switch (info)           
                {
                    case "+":
                        WhatToDo = Operations.Plus;
                        break;
                    case "−":
                        WhatToDo = Operations.Minus;
                        break;
                    case "×":
                        WhatToDo = Operations.Multiply;
                        break;
                    case "÷":
                        WhatToDo = Operations.Divide;
                        break;
                    default:
                        break;
                }
                CurrentState = State.ComputeP;
            }
            else
            {
                if (op.Contains(info)) ComputeP(true, info);
                else if (all.Contains(info) || comma.Contains(info) || (mr.Contains(info) && saved != ""))
                {
                    Accumulate2(true, info);
                }
            }
        }

        public void Accumulate2(bool isInput, string info)
        {
            if (isInput)
            {
                if (comma.Contains(info) && currentN == "")
                {
                    currentN = "0,";
                }
                else if (comma.Contains(info) && !currentN.Contains(","))
                {
                    currentN += info;
                }
                else if (all.Contains(info))
                {
                    if (currentN == "0") currentN = info;
                    else currentN += info;
                }
                else if (mr.Contains(info) && saved != "")
                {
                    currentN = saved;
                }
                else if (ce.Contains(info))
                {
                    currentN = "0";
                }
                invoker.Invoke(currentN);
                CurrentState = State.Accumulate2;
            }
            else
            {
                if (op.Contains(info))
                {
                    if (WhatToDo == Operations.Divide)
                    {
                        if (double.Parse(currentN) == 0) Error(true, info);
                        else
                        {
                            currentN = (firstN / double.Parse(currentN)).ToString();
                            invoker.Invoke(currentN);
                            ComputeP(true, info);
                        }
                    }
                    else
                    {
                        switch (WhatToDo)
                        {
                            case Operations.Plus:
                                currentN = (firstN + double.Parse(currentN)).ToString();
                                break;
                            case Operations.Minus:
                                currentN = (firstN - double.Parse(currentN)).ToString();
                                break;
                            case Operations.Multiply:
                                currentN = (firstN * double.Parse(currentN)).ToString();
                                break;
                            default:
                                break;
                        }
                        invoker.Invoke(currentN);
                        ComputeP(true, info);
                    }
                }
                else if (all.Contains(info))
                {
                    Accumulate2(true, info);
                }
                else if (comma.Contains(info) && !currentN.Contains(","))
                {
                    Accumulate2(true, info);
                }
                else if (equals.Contains(info))
                {
                    ComputeNoP(true, info);
                }
                else if (extrabutton.Contains(info))
                {
                    if (info == "√")
                    {
                        N = double.Parse(currentN);
                        if (N < 0) Error(true, info);
                        else
                        {
                            currentN = Math.Sqrt(N).ToString();
                            invoker.Invoke(currentN);
                        }
                    }
                    else
                    {
                        ExtraButton(info);
                        CurrentState = State.Accumulate2;
                    }
                }
                else if (square.Contains(info))
                {
                    N = double.Parse(currentN);
                    currentN = (N * N).ToString();
                    invoker.Invoke(currentN);
                    CurrentState = State.Accumulate2;
                }
                else if (inverse.Contains(info))
                {
                    N = double.Parse(currentN);
                    if (N == 0)
                    {
                        Error(true, info);
                    }
                    else
                    {
                        currentN = (1 / N).ToString();
                        invoker.Invoke(currentN);
                        CurrentState = State.Accumulate2;
                    }
                }
                else if (backspace.Contains(info))
                {
                    if (currentN.Length == 1)
                    {
                        currentN = "0";
                        Accumulate2(true, info);
                    }
                    else
                    {
                        currentN = currentN.Remove(currentN.Length - 1);
                        Accumulate2(true, info);
                    }
                }
                else if (c.Contains(info))
                {
                    Zero(true, info);
                }
                else if (ce.Contains(info))
                {
                    currentN = "";
                    invoker.Invoke("0");
                    Accumulate2(true, info);
                }
                else if (ms.Contains(info))
                {
                    saved = currentN;
                    Accumulate2(true, info);
                }
                else if (mr.Contains(info) && saved != "")
                {
                    Accumulate2(true, info);
                }
                else if (mc.Contains(info))
                {
                    saved = "";
                    Accumulate2(true, info);
                }
            }
        }

        public void ComputeNoP(bool isInput, string info)
        {
            if (isInput)
            {
                if (equals.Contains(info))
                {
                    if (WhatToDo == Operations.Divide)
                    {
                        if (double.Parse(currentN) == 0) Error(true, info);
                        else
                        {
                            currentN = (firstN / double.Parse(currentN)).ToString();
                            invoker.Invoke(currentN);
                            CurrentState = State.ComputeNoP;
                        }
                    }
                    else
                    {
                        switch (WhatToDo)
                        {
                            case Operations.Plus:
                                currentN = (firstN + double.Parse(currentN)).ToString();
                                break;
                            case Operations.Minus:
                                currentN = (firstN - double.Parse(currentN)).ToString();
                                break;
                            case Operations.Multiply:
                                currentN = (firstN * double.Parse(currentN)).ToString();
                                break;
                            default:
                                break;
                        }
                        invoker.Invoke(currentN);
                        CurrentState = State.ComputeNoP;
                    }
                }
                else if (mr.Contains(info))
                {
                    currentN = saved;
                    invoker.Invoke(currentN);
                }
            }
            else
            {
                if (non_zero.Contains(info))
                {
                    currentN = "";
                    Accumulate(true, info);
                }
                else if (zero.Contains(info))
                {
                    Zero(true, info);
                }
                else if (op.Contains(info))
                {
                    ComputeP(true, info);
                }
                else if (comma.Contains(info))
                {
                    currentN = "0";
                    Accumulate(true, info);
                }
                else if (extrabutton.Contains(info))
                {
                    if (info == "√")
                    {
                        N = double.Parse(currentN);
                        if (N < 0) Error(true, info);
                        else
                        {
                            currentN = Math.Sqrt(N).ToString();
                            invoker.Invoke(currentN);
                        }
                    }
                    else
                    {
                        ExtraButton(info);
                        CurrentState = State.ComputeNoP;
                    }
                }
                else if (square.Contains(info))
                {
                    N = double.Parse(currentN);
                    currentN = (N * N).ToString();
                    invoker.Invoke(currentN);
                    CurrentState = State.ComputeNoP;
                }
                else if (inverse.Contains(info))
                {
                    N = double.Parse(currentN);
                    if (N == 0)
                    {
                        Error(true, info);
                    }
                    else
                    {
                        currentN = (1 / N).ToString();
                        invoker.Invoke(currentN);
                        CurrentState = State.ComputeNoP;
                    }
                }
                else if (c.Contains(info) || ce.Contains(info))
                {
                    Zero(true, info);
                }
                else if (ms.Contains(info))
                {
                    saved = currentN;
                    ComputeNoP(true, info);
                }
                else if (mr.Contains(info) && saved != "")
                {
                    ComputeNoP(true, info);
                }
                else if (mc.Contains(info))
                {
                    saved = "";
                    ComputeNoP(true, info);
                }
            }
        }

        public void Error(bool isInput, string info)
        {
            if (isInput)
            {
                currentN = "Error";
                invoker.Invoke(currentN);
                currentN = "";
                CurrentState = State.Error;
            }
            else
            {
                if (non_zero.Contains(info))
                {
                    Accumulate(true, info);
                }
                else if (zero.Contains(info))
                {
                    Zero(true, info);
                }
            }
        }

        public void ExtraButton(string info)
        {
            N = double.Parse(currentN);
            switch (info)
            {
                case "±":
                    currentN = (-1 * N).ToString();
                    break;
                case "%":
                    currentN = (N / 100).ToString();
                    break;
                default:
                    break;
            }
            invoker.Invoke(currentN);
        }
    }
}
