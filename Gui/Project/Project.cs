using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OpenEmbeddedInterface.Gui
{
    public class Project
    {
        /// <summary>
        /// Gets or sets the name of the project.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the working directory of the project.
        /// </summary>
        public string WorkingDirectory { get; set; }
        /// <summary>
        /// Gets or sets the data interface for this project.
        /// </summary>
        public DataInterfaceType Interface { get; set; }

        /// <summary>
        /// Gets or sets the name of the project's hardware target.
        /// </summary>
        public string TargetName { get; set; }
        /// <summary>
        /// Gets or sets the name of the project's hardware vendor.
        /// </summary>
        public string TargetVendor { get; set; }
        /// <summary>
        /// Gets or sets a description of the project's hardware.
        /// </summary>
        public string TargetDescription { get; set; }

        /// <summary>
        /// Saves the project to the given working directory. Creates the working directory if it does not exist.
        /// </summary>
        public void Save()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Project));

            if (!Directory.Exists(WorkingDirectory))
            {
                Directory.CreateDirectory(WorkingDirectory);
            }

            StreamWriter stream = new StreamWriter(Path.Combine(WorkingDirectory, "InterfaceProject.iprj"));
            serializer.Serialize(stream, this);
            stream.Close();
        }

        /// <summary>
        /// Loads a given project from a working directory. This will set the working directory of the loaded project file to the working directory it was found in.
        /// </summary>
        /// <param name="workingDirectory">The working directory to load the project from.</param>
        /// <param name="setWorkingDirectory">Whether to set the working directory of the loaded project to the location it was loaded from.</param>
        /// <returns>The project object, otherwise null.</returns>
        static Project Load(string workingDirectory, bool setWorkingDirectory = true)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Project));
            StreamReader stream = new StreamReader(Path.Combine(workingDirectory, "InterfaceProject.iprj"));

            object project = serializer.Deserialize(stream);
            stream.Close();

            if (project is Project)
            {
                Project loadedProject = (Project)project;
                if (setWorkingDirectory)
                {
                    loadedProject.WorkingDirectory = workingDirectory;
                }
                return loadedProject;
            }
            else
            {
                return null; 
            }
        }
    }
}
