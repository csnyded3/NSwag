﻿using System.Threading.Tasks;
using NSwagStudio.ViewModels.CodeGenerators;

namespace NSwagStudio.Views.CodeGenerators
{
    public partial class SwaggerOutputView : ICodeGenerator
    {
        public SwaggerOutputView()
        {
            InitializeComponent();
        }

        public string Title => "Swagger Specification";

        private SwaggerOutputViewModel Model => (SwaggerOutputViewModel)Resources["ViewModel"];

        public Task GenerateClientAsync(string swaggerData)
        {
            return Model.GenerateClientAsync(swaggerData);
        }
    }
}
