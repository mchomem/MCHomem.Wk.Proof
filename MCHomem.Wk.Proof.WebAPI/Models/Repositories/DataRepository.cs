using System;
using System.IO;
using System.Text;

namespace MCHomem.Wk.Proof.WebAPI.Models.Repositories
{
    public class DataRepository
    {
        #region Fields

        private String defaultFileName = @"file.txt";
        private String defaultFilePathLeft = @"Files\Left";
        private String defaultFilePathRight = @"Files\Right";

        #endregion

        #region Properties

        private String FullPathLeft
        {
            get
            {
                StringBuilder pathLeft = new StringBuilder();
                pathLeft.Append(Directory.GetCurrentDirectory());
                pathLeft.Append(Path.DirectorySeparatorChar);
                pathLeft.Append(defaultFilePathLeft);
                pathLeft.Append(Path.DirectorySeparatorChar);
                pathLeft.Append(defaultFileName);
                return pathLeft.ToString();
            }
        }

        private String FullPathRight
        {
            get
            {
                StringBuilder pathRight = new StringBuilder();
                pathRight.Append(Directory.GetCurrentDirectory());
                pathRight.Append(Path.DirectorySeparatorChar);
                pathRight.Append(defaultFilePathRight);
                pathRight.Append(Path.DirectorySeparatorChar);
                pathRight.Append(defaultFileName);
                return pathRight.ToString();
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Reads and compare both Left and Right data.
        /// </summary>
        /// <returns>Returns a string indicate the difference between Left and Right data.</returns>
        public String ReadAndCompare()
        {
            String contentLeft = String.Empty;
            String contentRight = String.Empty;
            String result = String.Empty;

            if (!File.Exists(FullPathLeft) || !File.Exists(FullPathRight))
            {
                return "Para haver resultado, devem ser enviados os dados Left e Right para comparação.";
            }

            using (StreamReader sr = new StreamReader(FullPathLeft))
                contentLeft = sr.ReadToEnd();

            using (StreamReader sr = new StreamReader(FullPathRight))
                contentRight = sr.ReadToEnd();

            if (!contentLeft.Equals(contentRight) && (new FileInfo(FullPathLeft).Length.Equals(new FileInfo(FullPathRight).Length)))
            {
                result =
                    String.Format
                    (
                        "Os dados possuem o mesmo tamanho: Left {0} bytes e Right {1} bytes, mas não são iguais."
                        , new FileInfo(FullPathLeft).Length
                        , new FileInfo(FullPathRight).Length
                    );
            }
            else if (!contentLeft.Equals(contentRight))
            {
                result =
                    String.Format
                    (
                        "O dado Left possui {0} bytes e o dado Right possui {1} bytes."
                        , new FileInfo(FullPathLeft).Length
                        , new FileInfo(FullPathRight).Length
                    );
            }
            else if (contentLeft.Equals(contentRight))
            {
                result = "Os dados são iguais.";
            }

            return result;
        }

        /// <summary>
        /// Write the data in a file on server.
        /// </summary>
        /// <param name="data">The object Data</param>
        /// <param name="source">Enum that indicates the source (if left or right path)</param>
        public void Write(Data data, Source source)
        {
            using (StreamWriter sw = new StreamWriter((source.Equals(Source.Left) ? FullPathLeft : FullPathRight)))
                sw.Write(data.BinaryValue);
        }

        #endregion
    }
}
