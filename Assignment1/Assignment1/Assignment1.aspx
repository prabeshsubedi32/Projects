<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Assignment1.aspx.cs" Inherits="Assignment1.Assignment1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
table, th, td{
    border: 1px solid black;
    border-collapse: collapse;
  
}
</style>
    <title>
    </title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <caption>Displying Different Version of .Net Framework and their new Features</caption>
            <tr>
                <th style="width:300px">.NET Framework version</th>
                <th style ="width:500px">Features</th>
            </tr>
            <tr>
                <td style="text-align:center">3.5</td>
                <td><ul style="text-align:left">
                    <li>AJAX-enabled websites</li>
                    <li>LINQ</li>
                     <li>Dynamic data</li>    
                    </ul>
                    </td>
            </tr>
            <tr>
                <td style="text-align:center">4</td>
                <td><ul style="text-align:left">
                    <li>Expanded base class libraries</li>
                    <li>Cross-platform development with Portable Class Library </li>
                     <li>MEF, DLR, code contracts</li>    
                    </ul>
                    </td>
            </tr>
            <tr>
                <td style="text-align:center">4.5</td>
                <td><ul style="text-align:left">
                    <li>Support for Windows Store apps</li>
                    <li>WPF, WCF, WF, ASP.NET updates</li>    
                    </ul>
                    </td>
            </tr>
            <tr>
                <td style="text-align:center">4.5.1</td>
                <td><ul style="text-align:left">
                    <li>Support for Windows Phone Store apps</li>
                    <li>Automatic binding redirection</li>
                     <li>Performance and debugging improvements</li>    
                    </ul>
                    </td>
            </tr>
            <tr>
                <td style="text-align:center">4.5.2</td>
                <td><ul style="text-align:left">
                    <li>New APIs for transactional systems and ASP.NET</li>
                    <li>System DPI resizing in Windows Forms controls</li>
                     <li>Profiling improvements</li>  
                    <li>ETW and stress logging improvements</li>
                    </ul>
                    </td>
            </tr>
            <tr>
                <td style="text-align:center">4.6</td>
                <td><ul style="text-align:left">
                    <li>Compilation using .NET Native</li>
                    <li>ASP.NET Core 5</li>
                     <li>Event tracing improvements</li> 
                    <li>Support for page encodings</li>
                    </ul>
                    </td>
            </tr>
            <tr>
                <td style="text-align:center">4.6.1</td>
                <td><ul style="text-align:left">
                        <li>Support for X509 certificates containing ECDSA</li>
                        <li>Always Encrypted support for hardware protected keys in ADO.NET</li>
                        <li>Spell checking improvements in WPF</li>    
                    </ul>
                    </td>
            </tr>
            <tr>
                <td style="text-align:center">4.6.2</td>
                <td><ul style="text-align:left">
                        <li>Cryptography enhancements, including support for X509 certificates containing FIS 186-3 DSA</li>
                        <li>support for persisted-key symmetric encryption</li> 
                        <li>For Windows Presentation Foundation (WPF) apps, soft keyboard support, and per-monitor DPI.</li>
                        <li>ClickOnce support for the TLS 1.1 and TLS 1.2 protocols.</li>
                        <li>Support for converting Windows Forms and WPF apps to UWP apps.</li>
                    </ul>
                    </td>
            </tr>
            <tr>
                <td style="text-align:center">4.7</td>
                <td><ul style="text-align:left">
                    <li>Support for the level of TLS support provided by the operating system.</li>
                    <li>Ability to configure default message security settings for TLS1.1 or TLS1.2. </li>
                     <li>Improved reliability of the DataContractJsonSerializer.</li>
                    <li>Improved reliability of serialization and deserialization with WCF applications.</li>
                    <li>Use of Window's Print Document Package API for printing in WPF applications.</li>
                    </ul>
                    </td>
            </tr>
            <tr>
                <td style="text-align:center">4.7.1</td>
                <td><ul style="text-align:left">
                    <li>Support for .NET Standard 2.0.</li>
                    <li>Support for configuration builders, allowing the creation of configuration files at runtime.</li>
                     <li>Runtime feature detection, which allows you to determine whether a predefined feature is supported in the runtime environment.</li>    
                    <li>Serializable value tuples.</li>
                    <li>Improved performance for garbage collection.</li>
                    </ul>
                    </td>
            </tr>

        </table>
    </form>
</body>
</html>
