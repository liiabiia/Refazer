// Copyright (c) Microsoft Open Technologies, Inc.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Composition;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.Editting;
using Microsoft.CodeAnalysis.Formatting;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.FxCopAnalyzers.Design
{
    /// <summary>
    /// CA1012: Abstract classes should not have public constructors
    /// </summary>
    [ExportCodeFixProvider(LanguageNames.CSharp, LanguageNames.VisualBasic, Name = CA1012DiagnosticAnalyzer.RuleId), Shared]
    public sealed class CA1012CodeFixProvider : CodeFixProviderBase
    {
        public sealed override ImmutableArray<string> GetFixableDiagnosticIds()
        {
            return ImmutableArray.Create(CA1012DiagnosticAnalyzer.RuleId);
        }

        protected sealed override string GetCodeFixDescription(Diagnostic diagnostic)
        {
            return FxCopFixersResources.AbstractTypesShouldNotHavePublicConstructorsCodeFix;
        }

        private static SyntaxNode GetDeclaration(ISymbol symbol)
        {
            return (symbol.DeclaringSyntaxReferences.Length > 0) ? symbol.DeclaringSyntaxReferences[0].GetSyntax() : null;
        }

        internal override Task<Document> GetUpdatedDocumentAsync(Document document, SemanticModel model, SyntaxNode root, SyntaxNode nodeToFix, Diagnostic diagnostic, CancellationToken cancellationToken)
        {
            var classSymbol = (INamedTypeSymbol)model.GetDeclaredSymbol(nodeToFix);
            var instanceConstructors = classSymbol.InstanceConstructors.Where(t => t.DeclaredAccessibility == Accessibility.Public).Select(t => GetDeclaration(t)).Where(d => d != null).ToList();
            var generator = SyntaxGenerator.GetGenerator(document);
            var newRoot = root.ReplaceNodes(instanceConstructors, (original, rewritten) => generator.WithAccessibility(original, Accessibility.Protected));
            return Task.FromResult(document.WithSyntaxRoot(newRoot));
        }
    }


    [ExportCodeFixProvider(LanguageNames.CSharp, LanguageNames.VisualBasic, Name = "CA2237 CodeFix provider"), Shared]
    public sealed class CA2237CodeFixProvider : CodeFixProviderBase
    {
        public sealed override ImmutableArray<string> GetFixableDiagnosticIds()
        {
            return ImmutableArray.Create(SerializationRulesDiagnosticAnalyzer.RuleCA2237Id);
        }

        protected sealed override string GetCodeFixDescription(Diagnostic diagnostic)
        {
            return FxCopFixersResources.AddSerializableAttribute;
        }

        internal override Task<Document> GetUpdatedDocumentAsync(Document document, SemanticModel model, SyntaxNode root, SyntaxNode nodeToFix, Diagnostic diagnostic, CancellationToken cancellationToken)
        {
            var generator = SyntaxGenerator.GetGenerator(document);
            var attr = generator.Attribute(generator.TypeExpression(WellKnownTypes.SerializableAttribute(model.Compilation)));
            var newNode = generator.AddAttributes(nodeToFix, attr);
            return Task.FromResult(document.WithSyntaxRoot(root.ReplaceNode(nodeToFix, newNode)));
        }
    }
}