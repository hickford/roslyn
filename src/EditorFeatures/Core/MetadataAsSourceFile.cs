// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.


namespace Microsoft.CodeAnalysis.Editor
{
    internal sealed class MetadataAsSourceFile
    {
        private readonly string _filePath;
        private readonly Location _identifierLocation;
        private readonly string _documentTitle;
        private readonly string _documentTooltip;

        internal MetadataAsSourceFile(string filePath, Location identifierLocation, string documentTitle, string documentTooltip)
        {
            _filePath = filePath;
            _identifierLocation = identifierLocation;
            _documentTitle = documentTitle;
            _documentTooltip = documentTooltip;
        }

        public string FilePath => _filePath;
        public Location IdentifierLocation => _identifierLocation;
        public string DocumentTitle => _documentTitle;
        public string DocumentTooltip => _documentTooltip;
    }
}
