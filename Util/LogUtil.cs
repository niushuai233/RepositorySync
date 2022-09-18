using log4net;
using System;

namespace Util
{
    public class LogUtil
    {
        /// <summary>
        /// 默认log实例
        /// </summary>
        private static ILog LOG = LogManager.GetLogger("ALL");

        /// <summary>
        /// 默认控制台logger debug
        /// </summary>
        /// <param name="message">输出内容</param>
        public static void Debug(string message)
        {
            LOG.Debug(message);
        }
        /// <summary>
        /// 默认控制台logger debug
        /// </summary>
        /// <param name="message">输出内容</param>
        /// <param name="exception">异常堆栈</param>
        public static void Debug(string message, Exception exception)
        {
            LOG.Debug(message, exception);
        }
        /// <summary>
        /// 默认控制台logger info
        /// </summary>
        /// <param name="message"></param>
        public static void Info(string message)
        {
            LOG.Info(message);
        }
        /// <summary>
        /// 默认控制台logger info
        /// </summary>
        /// <param name="message">输出内容</param>
        /// <param name="exception">异常堆栈</param>
        public static void Info(string message, Exception exception)
        {
            LOG.Info(message, exception);
        }
        /// <summary>
        /// 默认控制台logger warn
        /// </summary>
        /// <param name="message">输出内容</param>
        public static void Warn(string message)
        {
            LOG.Warn(message);
        }

        /// <summary>
        /// 默认控制台logger warn
        /// </summary>
        /// <param name="message">输出内容</param>
        /// <param name="exception">异常堆栈</param>
        public static void Warn(string message, Exception exception)
        {
            LOG.Warn(message, exception);
        }

        /// <summary>
        /// 默认控制台logger error
        /// </summary>
        /// <param name="message">输出内容</param>
        public static void Error(string message)
        {
            LOG.Error(message);
        }

        /// <summary>
        /// 默认控制台logger error
        /// </summary>
        /// <param name="message">输出内容</param>
        /// <param name="exception">异常堆栈</param>
        public static void Error(string message, Exception exception)
        {
            LOG.Error(message, exception);
        }

        /// <summary>
        /// 默认控制台logger fatal
        /// </summary>
        /// <param name="message">输出内容</param>
        public static void Fatal(string message)
        {
            LOG.Fatal(message);
        }

        /// <summary>
        /// 默认控制台logger fatal
        /// </summary>
        /// <param name="message">输出内容</param>
        /// <param name="exception">异常堆栈</param>
        public static void Fatal(string message, Exception exception)
        {
            LOG.Fatal(message, exception);
        }

        /// <summary>
        /// 获取指定的logger
        /// </summary>
        /// <param name="loggerNmae"></param>
        /// <returns></returns>
        public static ILog GetLogger(string loggerNmae)
        {
            return LogManager.GetLogger(loggerNmae);
        } 
    }
}
