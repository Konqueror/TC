using System;
using System.Text;

using System.CodeDom.Compiler;
using System.IO;
using Microsoft.CSharp;
using System.Reflection;

namespace DynaCode
{
    class Program
    {
        static string[] code = new string[1];

        static void Main(string[] args)
        {
            StringBuilder expression = new StringBuilder();
            string input = Console.ReadLine();
            expression.Append(input);
            expression.Replace("sqrt", "Math.Sqrt");
            expression.Replace("pow", "Math.Pow");
            expression.Replace("ln", "Math.Log");

            code[0] = 
            "using System;"+
            "namespace DynaCore"+
            "{"+
            "   public class DynaCore"+
            "   {"+
            "       static public void Main(string str)"+
            "       {"+
                        "Console.WriteLine(" + expression +");" +
            "       }"+
            "   }"+
            "}";

            CompileAndRun(code);

            Console.ReadKey();
        }

        static void CompileAndRun(string[] code)
        {
            CompilerParameters CompilerParams = new CompilerParameters();
            string outputDirectory = Directory.GetCurrentDirectory();

            CompilerParams.GenerateInMemory = true;
            CompilerParams.TreatWarningsAsErrors = false;
            CompilerParams.GenerateExecutable = false;
            CompilerParams.CompilerOptions = "/optimize";

            string[] references = { "System.dll" };
            CompilerParams.ReferencedAssemblies.AddRange(references);

            CSharpCodeProvider provider = new CSharpCodeProvider();
            CompilerResults compile = provider.CompileAssemblyFromSource(CompilerParams, code);

            if (compile.Errors.HasErrors)
            {
                string text = "Compile error: ";
                foreach (CompilerError ce in compile.Errors)
                {
                    text += "rn" + ce.ToString();
                }
                throw new Exception(text);
            }

            //ExpoloreAssembly(compile.CompiledAssembly);

            Module module = compile.CompiledAssembly.GetModules()[0];
            Type mt = null;
            MethodInfo methInfo = null;

            if (module != null)
            {
                mt = module.GetType("DynaCore.DynaCore");
            }

            if (mt != null)
            {
                methInfo = mt.GetMethod("Main");
            }

            if (methInfo != null)
            {
                Console.WriteLine(methInfo.Invoke(null, new object[] { "here in dyna code" }));
            }
        }
    }
}