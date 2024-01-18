using System;


namespace R5T.O0030.O000
{
    public class ProjectOperations : IProjectOperations
    {
        #region Infrastructure

        public static IProjectOperations Instance { get; } = new ProjectOperations();


        private ProjectOperations()
        {
        }

        #endregion
    }
}
