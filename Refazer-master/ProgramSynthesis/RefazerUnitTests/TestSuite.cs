﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.ProgramSynthesis;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RefazerFunctions.Spg.Config;
using RefazerManager;
using RefazerObject.Constants;
using RefazerObject.Location;
using RefazerObject.Region;
using RefazerObject.Transformation;
using Spg.LocationRefactor.Location;
using Taramon.Exceller;
using TreeEdit.Spg.Log;
using TreeEdit.Spg.LogInfo;
using TreeEdit.Spg.Transform;
using TreeElement;

namespace RefazerUnitTests
{
    [TestClass]
    public class TestSuite
    {
        [TestMethod]
        public void E1()
        {
            var isCorrect = CompleteTestBase(@"EntityFramewok\1");
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void E2()
        {
            var isCorrect = CompleteTestBase(@"EntityFramewok\2");
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void E3()
        {
            var isCorrect = CompleteTestBase(@"EntityFramewok\3", solutionPath: @"EntityFramework\entityframework10\EntityFramework.sln");
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void E4()
        {
            var isCorrect = CompleteTestBase(@"EntityFramewok\4");
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void E5()
        {
            var isCorrect = CompleteTestBase(@"EntityFramewok\5");
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void E6()
        {
            var isCorrect = CompleteTestBase(@"EntityFramewok\6");
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void E7()
        {
            var isCorrect = CompleteTestBase(@"EntityFramewok\7");
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void E8()
        {
            var isCorrect = CompleteTestBase(@"EntityFramewok\8", solutionPath: @"EntityFramework\entityframework7\EntityFramework.sln");
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void E9()
        {
            var isCorrect = CompleteTestBase(@"EntityFramewok\9");
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void E10()
        {
            var isCorrect = CompleteTestBase(@"EntityFramewok\10");
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void E11()
        {
            var isCorrect = CompleteTestBase(@"EntityFramewok\11", solutionPath: @"EntityFramework\entityframework2\EntityFramework.sln");
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void E12()
        {
            var isCorrect = CompleteTestBase(@"EntityFramewok\12");
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void N13()
        {
            var isCorrect = CompleteTestBase(@"NuGet\13", kinds: new List<SyntaxKind> { SyntaxKind.PropertyDeclaration });
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void N14()
        {
            var isCorrect = CompleteTestBase(@"NuGet\14", solutionPath: @"NuGet\nuget3\NuGet.sln");
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void N15()
        {
            var isCorrect = CompleteTestBase(@"NuGet\15");
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void N16()
        {
            var isCorrect = CompleteTestBase(@"NuGet\16", solutionPath: @"NuGet\nuget4\NuGet.sln");
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void N17()
        {
            var isCorrect = CompleteTestBase(@"NuGet\17");
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void N18()
        {
            var isCorrect = CompleteTestBase(@"NuGet\18", solutionPath: @"NuGet\nuget2\NuGet.sln");
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void N19()
        {
            var isCorrect = CompleteTestBase(@"NuGet\19");
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void N20()
        {
            var isCorrect = CompleteTestBase(@"NuGet\20");
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void N21()
        {
            var isCorrect = CompleteTestBase(@"Nuget\21", solutionPath: @"NuGet\nuget7\NuGet.sln");
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void N22()
        {
            var isCorrect = CompleteTestBase(@"NuGet\22");
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void N23()
        {
            var isCorrect = CompleteTestBase(@"NuGet\23");
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void N24()
        {
            var isCorrect = CompleteTestBase(@"NuGet\24");
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void N25()
        {
            var isCorrect = CompleteTestBase(@"NuGet\25");
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void N26()
        {
            var isCorrect = CompleteTestBase(@"NuGet\26");
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void N27()
        {
            var isCorrect = CompleteTestBase(@"NuGet\27");
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void N28()
        {
            var isCorrect = CompleteTestBase(@"NuGet\28", solutionPath: @"NuGet\nuget6\NuGet.sln",
                kinds: new List<SyntaxKind> { SyntaxKind.AttributeList });
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void N29()
        {
            var isCorrect = CompleteTestBase(@"NuGet\29", solutionPath: @"NuGet\nuget10\NuGet.sln");
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void R30()
        {
            var isCorrect = CompleteTestBase(@"Roslyn\30");
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void R31()
        {
            var isCorrect = CompleteTestBase(@"Roslyn\31", solutionPath: @"Roslyn\roslyn7\src\Roslyn.sln", kinds: new List<SyntaxKind> { SyntaxKind.ClassDeclaration });
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void R32()
        {
            var isCorrect = CompleteTestBase(@"Roslyn\32", solutionPath: @"Roslyn\roslyn18\Src\Roslyn.sln", kinds: new List<SyntaxKind> { SyntaxKind.MethodDeclaration, SyntaxKind.PropertyDeclaration });
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void R33()
        {
            var isCorrect = CompleteTestBase(@"Roslyn\33");
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void R34()
        {
            var isCorrect = CompleteTestBase(@"Roslyn\34");
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void R35()
        {
            var isCorrect = CompleteTestBase(@"Roslyn\35", solutionPath: @"Roslyn\roslyn\src\Roslyn.sln");
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void R36()
        {
            var isCorrect = CompleteTestBase(@"Roslyn\36");
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void R37()
        {
            var isCorrect = CompleteTestBase(@"Roslyn\37");
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void R38()
        {
            var isCorrect = CompleteTestBase(@"Roslyn\38");
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void R39()
        {
            var isCorrect = CompleteTestBase(@"Roslyn\39");
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void R40()
        {
            var isCorrect = CompleteTestBase(@"Roslyn\40");
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void R41()
        {
            var isCorrect = CompleteTestBase(@"Roslyn\41", solutionPath: @"Roslyn\roslyn7\src\Roslyn.sln");
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void R42()
        {
            var isCorrect = CompleteTestBase(@"Roslyn\42");
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void R43()
        {
            var isCorrect = CompleteTestBase(@"Roslyn\43");
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void R44()
        {
            var isCorrect = CompleteTestBase(@"Roslyn\44");
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void R45()
        {
            var isCorrect = CompleteTestBase(@"Roslyn\45");
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void R46()
        {
            var isCorrect = CompleteTestBase(@"Roslyn\46");
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void R47()
        {
            var isCorrect = CompleteTestBase(@"Roslyn\47");
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void R48()
        {
            var isCorrect = CompleteTestBase(@"Roslyn\48");
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void R49()
        {
            var isCorrect = CompleteTestBase(@"Roslyn\49");
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void R50()
        {
            var isCorrect = CompleteTestBase(@"Roslyn\50", kinds: new List<SyntaxKind> { SyntaxKind.ConstructorDeclaration });
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void R51()
        {
            var isCorrect = CompleteTestBase(@"Roslyn\51");
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void R52()
        {
            var isCorrect = CompleteTestBase(@"Roslyn\52");
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void R53()
        {
            var isCorrect = CompleteTestBase(@"Roslyn\53");
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void R54()
        {
            var isCorrect = CompleteTestBase(@"Roslyn\54", solutionPath: @"Roslyn\roslyn7\src\Roslyn.sln",
                kinds: new List<SyntaxKind> { SyntaxKind.UsingDirective });
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void R55()
        {
            var isCorrect = CompleteTestBase(@"Roslyn\55");
            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void R56()
        {
            var isCorrect = CompleteTestBase(@"Roslyn\56");
            Assert.IsTrue(isCorrect);
        }

        /// <summary>
        /// Gets the domain specific grammar
        /// </summary>
        public static Grammar GetGrammar()
        {
            string path = FileUtil.GetBasePath() + @"\ProgramSynthesis\grammar\Transformation.grammar";
            var grammar = Utils.LoadGrammar(path);
            return grammar;
        }

        /// <summary>
        /// Complete test
        /// </summary>
        /// <param name="commit">Commit where the change occurs</param>
        /// <param name="solutionPath">Path to the solution.</param>
        /// <param name="kinds">Kinds that will be transformed.</param>
        /// <returns>True if pass test</returns>
        public static bool CompleteTestBase(string commit, string solutionPath = null, List<SyntaxKind> kinds = null)
        {
            string expHome = RefazerObject.Environment.Environment.ExpHome();
            if (expHome.IsEmpty()) throw new Exception("Environment variable for the experiment not defined");

            if (kinds == null)
            {
                kinds = new List<SyntaxKind> { SyntaxKind.MethodDeclaration, SyntaxKind.ConstructorDeclaration };
            }
            //Load grammar
            var grammar = GetGrammar();
            var pathTransformed = expHome + TestConstants.MetadataFolder + @"\" + commit + TestConstants.TransformedLocations;
            var codeTransformations = JsonUtil<List<CodeTransformation>>.Read(pathTransformed);

            List<Region> regions = codeTransformations.Select(entry => entry.Trans).ToList();
            var locations = codeTransformations.Select(entry => entry.Location).ToList();
            var globalTransformations = RegionManager.GetInstance().GroupTransformationsBySourcePath(codeTransformations);

            //Random number generator with a seed.
            int seed = 86028157;
            Random random = new Random(seed);
            var randomList = Enumerable.Range(0, locations.Count).OrderBy(o => random.Next()).ToList();
            var examples = randomList.GetRange(0, 2);

            //Execution
            TestHelper helper;
            double mean = -1.0;
            while (true)
            {
                var execId = "ranking";
                CodeFragmentsInfo.GetInstance().Init();
                TransformationInfos.GetInstance().Init();
                examples.Sort();
                helper = new TestHelper(grammar, regions, locations, globalTransformations, expHome, solutionPath, commit, kinds, execId);
                helper.Execute(examples);

                var regionsFragments = CodeFragmentsInfo.GetInstance().Locations.Select(o => new Region { Start = o.Span.Start, Length = o.Span.Length, Text = o.ToString(), Path = o.SyntaxTree.FilePath }).ToList();
                string transformedPath = expHome + TestConstants.MetadataFolder + "\\" + commit + TestConstants.TransformedLocationsAll + execId + ".json";
                var regionsFrags = new List<Region>();
                foreach (var region in regionsFragments)
                {
                    if (region.Path.ToUpperInvariant().Contains(expHome.ToUpperInvariant()))
                    {
                        var regionPathUpper = region.Path.ToUpperInvariant();
                        var index = expHome.Length;
                        var substring = regionPathUpper.Substring(index, regionPathUpper.Length - index);
                        region.Path = substring;
                        regionsFrags.Add(region);
                    }
                    else
                    {
                        regionsFrags.Add(region);
                    }
                }
                JsonUtil<List<Region>>.Write(regionsFrags, transformedPath);
                if (SynthesisConfig.GetInstance().CreateLog)
                {
                    var scriptsizes = GetDataAndSaveToFile(commit, expHome, execId, Constants.ScriptSize);
                    var sizes = scriptsizes.Split(new[] { "\n" }, StringSplitOptions.None).Select(int.Parse);
                    mean = sizes.Average();
                }
                var transformations = TransformationInfos.GetInstance().Transformations;
                var beforeafter = new List<Tuple<Region, string, string>>();
                foreach (var o in transformations)
                {
                    var filePath = o.Before.SyntaxTree.FilePath.ToUpperInvariant();
                    if (o.Before.SyntaxTree.FilePath.ToUpperInvariant().Contains(expHome.ToUpperInvariant()))
                    {
                        var index = expHome.Length;
                        filePath = filePath.Substring(index, filePath.Length - index);
                    }        
                    var region = new Region
                    {
                        Start = o.Before.Span.Start,
                        Length = o.Before.Span.Length,
                        Text = o.Before.ToString(),
                        Path = filePath
                    };
                    beforeafter.Add(Tuple.Create(region, o.After.ToString(), filePath));
                }
                GetDataAndSaveToFile(commit, expHome, execId, Constants.Programs);
                var foundLocations = GetEditedLocations(regionsFrags, locations);
                var firstProblematicLocation = GetFirstNotFound(foundLocations, locations, randomList);
                if (firstProblematicLocation == -1)
                {
                    //Generate meta-data for BaselineBeforeAfterList on commit.
                    var foundList = GetEditionInLocations(regionsFrags, locations);
                    JsonUtil<List<Region>>.Write(foundList, expHome + TestConstants.MetadataFolder + "\\"+ commit + TestConstants.TransformedLocationsTool + execId + ".json");
                    var beforeafterList = GetBeforeAfterData(beforeafter, locations);
                    JsonUtil<List<Tuple<Region, string, string>>>.Write(beforeafterList, expHome + TestConstants.MetadataFolder + "\\" + commit + TestConstants.BeforeAfterLocationsTool + execId + ".json");
                    JsonUtil<List<Tuple<Region, string, string>>>.Write(beforeafter, expHome + TestConstants.MetadataFolder + "\\" + commit + TestConstants.BeforeAfterLocationsAll + execId + ".json");
                    //Comparing edited locations with baseline
                    var baselineBeforeAfterList = JsonUtil<List<Tuple<Region, string, string>>>.Read(expHome + TestConstants.MetadataFolder + "\\" + commit + TestConstants.BeforeAfterLocations + execId + ".json");
                    var baselineBeforeAfter = new List<Tuple<Region, string, string>>();
                    foreach (var baseline in baselineBeforeAfterList)
                    {
                        var region = baseline.Item1;
                        region.Path = region.Path.ToUpperInvariant();
                        baselineBeforeAfter.Add(Tuple.Create(region, baseline.Item2, baseline.Item3.ToUpperInvariant()));
                    }
                    var notTransformed = foundList.Except(beforeafterList.Select(o => o.Item1)).ToList();
                    var firstIncorrect = GetFirstIncorrect(beforeafterList, baselineBeforeAfter, randomList, locations, notTransformed);
                    if (firstIncorrect == -1)
                    {
                        try
                        {
                            var transformedDocuments = ASTTransformer.Transform(TransformationInfos.GetInstance().Transformations);
                            GeneratedDiffEdits(commit, transformedDocuments);
                        }
                        catch (Exception)
                        {
                            // ignored
                            //throw new Exception("Errors in transforming the locations.");
                        }
                        break;
                    }
                    firstProblematicLocation = firstIncorrect;
                }
                if (examples.Contains(firstProblematicLocation))
                {
                    try
                    {
                        var transformedDocuments = ASTTransformer.Transform(TransformationInfos.GetInstance().Transformations);
                        GeneratedDiffEdits(commit, transformedDocuments);
                    }
                    catch (Exception)
                    {
                        // ignored
                        //throw new Exception("Errors in transforming the locations.");
                    }
                    throw new Exception("A transformation could not be learned using this examples.");
                }
                examples.Add(firstProblematicLocation);
            }
            //end of execution 
            long totalTimeToLearn = helper.TotalTimeToLearn;
            long totalTimeToExecute = helper.TotalTimeToLearn;
            var transformed = helper.Transformed;
            var program = helper.Program;
            var dictionarySelection = helper.DictionarySelection;

            /*Log(commit,
                totalTimeToLearn + totalTimeToExecute,
                examples.Count,
                regions.Count,
                transformed.Count,
                dictionarySelection.Count,
                program.ToString(),
                totalTimeToLearn,
                totalTimeToExecute,
                mean);*/
            return true;
        }

        [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
        private static void GeneratedDiffEdits(string commit, List<Tuple<SyntaxNodeOrToken, SyntaxNodeOrToken>> transformedList)
        {
            string expHome = RefazerObject.Environment.Environment.ExpHome();
            string output = "";
            string errors = "";
            var pathoutput = expHome + TestConstants.MetadataFolder + "\\" + commit + TestConstants.DiffFolder;
            foreach (var ba in transformedList)
            {
                var className = ba.Item1.SyntaxTree.FilePath.Split(@"\".ToCharArray()).Last();
                var pathb = expHome + TestConstants.MetadataFolder + "\\" + commit + TestConstants.BeforeFile + className;
                var patha = expHome + TestConstants.MetadataFolder + "\\" + commit + TestConstants.AfterFile + className;
                FileUtil.WriteToFile(pathb, ba.Item1.ToString());
                FileUtil.WriteToFile(patha, ba.Item2.ToString());

                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = $"/C diff {pathb} {patha} -U5";
                process.StartInfo = startInfo;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.Start();

                output += process.StandardOutput.ReadToEnd();
                errors += process.StandardError.ReadToEnd();
            }

            if (!output.IsEmpty())
            {
                FileUtil.WriteToFile(pathoutput, output);
            }
            else if (!errors.IsEmpty())
            {
                FileUtil.WriteToFile(pathoutput, errors);
            }
            else
            {
                FileUtil.WriteToFile(pathoutput, "Occurs an error while running process.");
            }
        }

        private static int GetFirstIncorrect(List<Tuple<Region, string, string>> toolBeforeAfterList, List<Tuple<Region, string, string>> baselineBeforeAfterList, List<int> randomList, List<CodeLocation> locations, List<Region> notTransformed)
        {
            //computing list of locations that do not follow the baseline.
            var notFoundList = baselineBeforeAfterList.Where(o => !toolBeforeAfterList.Contains(o)).ToList();
            var notTranformedCodeLocations = notTransformed.Select(o => Tuple.Create(o, o.Path, o.Text)).ToList();
            notFoundList.AddRange(notTranformedCodeLocations);
            if (!notFoundList.Any()) return -1;
            //Computing example locations that do not follow the baseline.
            var incorrectLocationsList = locations.Where(o => notFoundList.Any(e => o.Region.IntersectWith(e.Item1))).ToList();
            //Computing the index of the locations that do not follow the baseline.
            var notFoundIndexList = incorrectLocationsList.Select(o => locations.IndexOf(o)).ToList();
            //Getting the index of the location in the random list.
            var index = randomList.FindIndex(o => notFoundIndexList.Contains(o));
            if (index == -1) return -1;
            var firstNotFound = randomList[index];
            return firstNotFound;
        }

        private static List<Tuple<Region, string, string>> GetBeforeAfterData(List<Tuple<Region, string, string>> regions, List<CodeLocation> locations)
        {
            var dictionary = CreateDictionaryMatch(locations, regions.Select(o => o.Item1).ToList());
            var foundList = new List<Region>();
            dictionary.Values.ForEach(o => foundList.AddRange(o));
            foundList = foundList.Distinct().ToList();
            var regionsFound = regions.Where(o => foundList.Contains(o.Item1)).ToList();
            return regionsFound;
        }

        public static List<Tuple<string, string, string>> Transform(Dictionary<string, List<Tuple<Region, string, string>>> transformations)
        {
            List<Tuple<string, string, string>> tRegions = new List<Tuple<string, string, string>>();
            foreach (var item in transformations)
            {
                int nextStart = 0;
                var filePath = item.Value.First().Item3;
                var source = FileUtil.ReadFile(filePath);
                string sourceCode = source;
                foreach (var tregion in item.Value)
                {
                    Region region = tregion.Item1;
                    string transformation = tregion.Item2;

                    int start = nextStart + region.Start;
                    int end = start + region.Length;
                    var sourceCodeUntilStart = sourceCode.Substring(0, start);
                    var sourceCodeAfterSelection = sourceCode.Substring(end);
                    sourceCode = sourceCodeUntilStart + transformation + sourceCodeAfterSelection;

                    nextStart += transformation.Length - region.Length;
                }
                tRegions.Add(Tuple.Create(source, sourceCode, filePath));
            }
            return tRegions;
        }

        private static string GetDataAndSaveToFile(string commit, string expHome, string seed, string fileName)
        {
            string file = expHome + fileName + ".txt";
            var fragments = FileUtil.ReadFile(file);
            var pathToOutput = expHome + TestConstants.MetadataFolder + "\\" + commit + "\\" + fileName + seed + ".res";
            FileUtil.WriteToFile(pathToOutput, fragments);
            File.Delete(file);
            return fragments;
        }

        private static int GetFirstNotFound(List<CodeLocation> foundLocations, List<CodeLocation> locations, List<int> result)
        {
            var notFoundList = locations.Where(o => !foundLocations.Contains(o)).ToList();
            if (!notFoundList.Any()) return -1;

            var notFoundIndexList = notFoundList.Select(o => locations.IndexOf(o));
            var index = result.FindIndex(o => notFoundIndexList.Contains(o));
            var firstNotFound = result[index];
            return firstNotFound;
        }

        private static List<CodeLocation> GetEditedLocations(List<Region> regions, List<CodeLocation> locations)
        {
            var dictionary = CreateDictionaryMatch(locations, regions);
            var found = dictionary.Where(o => o.Value.Any()).Select(o => o.Key).ToList();
            return found;
        }

        private static List<Region> GetEditionInLocations(List<Region> regions, List<CodeLocation> locations)
        {
            var dictionary = CreateDictionaryMatch(locations, regions);

            var foundList = new List<Region>();
            dictionary.Values.ForEach(o => foundList.AddRange(o));
            foundList = foundList.Distinct().ToList();
            return foundList;
        }

        private static Dictionary<CodeLocation, List<Region>> CreateDictionaryMatch(List<CodeLocation> locations, List<Region> regions)
        {
            var dictionary = new Dictionary<CodeLocation, List<Region>>();
            foreach (var v in locations)
            {
                var matches = regions.Where(o => v.Region.IntersectWith(o)).ToList();
                if (!dictionary.ContainsKey(v))
                {
                    dictionary[v] = new List<Region>();
                }
                dictionary[v].AddRange(matches);
            }
            return dictionary;
        }

        public static void Log(string commit, double time, int exTransformations, int locations, int acTrasnformation,
            int documents, string program, double timeToLearnEdit, double timeToTransformEdit, double mean)
        {
            string commitFirstLetter = commit.ElementAt(0).ToString();
            string commitId = commit.Substring(commit.IndexOf(@"\") + 1);

            commit = /*commitFirstLetter + "-" +*/ commitId;

            string path = LogData.LogPath();
            using (ExcelManager em = new ExcelManager())
            {

                em.Open(path);

                int empty;
                for (int i = 1; ; i++)
                {
                    if (em.GetValue("A" + i, Category.Formatted).ToString().Equals("") ||
                        em.GetValue("A" + i, Category.Formatted).ToString().Equals(commit))
                    {
                        empty = i;
                        break;
                    }
                }

                em.SetValue("A" + empty, commit);
                em.SetValue("B" + empty, time / 1000);
                em.SetValue("C" + empty, exTransformations);
                em.SetValue("D" + empty, locations);
                em.SetValue("E" + empty, acTrasnformation);
                em.SetValue("F" + empty, documents);
                em.SetValue("G" + empty, program);
                em.SetValue("H" + empty, timeToLearnEdit / 1000);
                em.SetValue("I" + empty, timeToTransformEdit / 1000);
                em.SetValue("J" + empty, mean);
                em.Save();
            }
        }

        public static void LogProgram(string commit, int programIndex, string program, bool status)
        {
            string commitFirstLetter = commit.ElementAt(0).ToString();
            string commitId = commit.Substring(commit.IndexOf(@"\") + 1);

            commit = commitId;

            string path = LogData.LogPath();
            using (ExcelManager em = new ExcelManager())
            {
                em.Open(path);

                int empty;
                for (int i = 1; ; i++)
                {
                    if (em.GetValue("A" + i, Category.Formatted).ToString().Equals("") ||
                        em.GetValue("A" + i, Category.Formatted).ToString().Equals(commit) && em.GetValue("B" + i, Category.Formatted).ToString().Equals(programIndex.ToString()))
                    {
                        empty = i;
                        break;
                    }
                }

                em.SetValue("A" + empty, commit);
                em.SetValue("B" + empty, programIndex);
                em.SetValue("C" + empty, program);
                em.SetValue("D" + empty, status);
                em.Save();
            }
        }
    }
}
/*
        static string GetTestDataFolder(string testDataLocation)
        {
            string startupPath = System.AppDomain.CurrentDomain.BaseDirectory;
            var pathItems = startupPath.Split(Path.DirectorySeparatorChar);
            string projectPath = String.Join(Path.DirectorySeparatorChar.ToString(),
                pathItems.Take(pathItems.Length - 4));
            string result = projectPath + testDataLocation;
            return result;
        }

        public static string GetBasePath()
        {
            string path = GetTestDataFolder(@"\");
            return path;
        }

        public static Grammar GetGrammar()
        {
            string path = GetBasePath();
            var grammar = Utils.LoadGrammar(path + @"ProgramSynthesis\grammar\Transformation.grammar");
            return grammar;
        }

        ///// <summary>
        ///// Complete test
        ///// </summary>
        ///// <param name="commit">Commit where the change occurs</param>
        ///// <returns>True if pass test</returns>
        //public static bool CompleteTestBase(string commit, string solutionPath = null, List<SyntaxKind> kinds = null)
        //{
        //    if (kinds == null)
        //    {
        //        kinds = new List<SyntaxKind> { SyntaxKind.MethodDeclaration, SyntaxKind.ConstructorDeclaration };
        //    }

        //    //Load grammar
        //    var grammar = GetGrammar();

        //    string expHome = Environment.GetEnvironmentVariable("EXP_HOME", EnvironmentVariableTarget.User);
        //    var codeTransformations = JsonUtil<List<CodeTransformation>>.Read(expHome + @"cprose\" + commit + @"\metadata\transformed_locations.json");

        //    List<Region> regions = codeTransformations.Select(entry => entry.Trans).ToList();
        //    var locations = codeTransformations.Select(entry => entry.Location).ToList();
        //    var globalTransformations = RegionManager.GetInstance().GroupTransformationsBySourcePath(codeTransformations);

        //    //Random number generator with a seed.
        //    int seed = 86028157;
        //    //int seed = 104395301;
        //    //int seed = 122949829;
        //    //int seed = 141650963;
        //    //int seed = 160481219;
        //    Random random = new Random(seed);
        //    var randomList = Enumerable.Range(0, locations.Count).OrderBy(o => random.Next()).ToList();
        //    var examples = randomList.GetRange(0, 2);

        //    //Execution
        //    TestHelper helper;
        //    string scriptsizes;
        //    while (true)
        //    {
        //        examples.Sort();
        //        helper = new TestHelper(grammar, regions, locations, globalTransformations, expHome, solutionPath, commit, kinds, seed);
        //        helper.Execute(examples);

        //        string codeFragments = "codefragments";
        //        var fragments = GetDataAndSaveToFile(commit, expHome, seed, codeFragments);
        //        var regionsFrags = ConvertFragmentsToRegions(fragments);
        //        JsonUtil<List<Region>>.Write(regionsFrags, expHome + @"cprose\" + commit + @"\metadata\transformed_locationsAll" + seed + ".json");

        //        string scriptsize = "scriptsize";
        //        scriptsizes = GetDataAndSaveToFile(commit, expHome, seed, scriptsize);

        //        string beforeafter = "beforeafter";
        //        beforeafter = GetDataAndSaveToFile(commit, expHome, seed, beforeafter);

        //        string programs = "programs";
        //        programs = GetDataAndSaveToFile(commit, expHome, seed, programs);

        //        var foundLocations = GetEditedLocations(fragments, locations);
        //        var firstProblematicLocation = GetFirstNotFound(foundLocations, locations, randomList);

        //        if (firstProblematicLocation == -1)
        //        {
        //            //Generate meta-data for BaselineBeforeAfterList on commit.
        //            var foundList = GetEditionInLocations(fragments, locations);
        //            JsonUtil<List<Region>>.Write(foundList, expHome + @"cprose\" + commit + @"\metadata_tool\transformed_locations"+ seed +".json");

        //            var beforeafterList = GetBeforeAfterData(beforeafter, locations);
        //            JsonUtil<List<Tuple<Region, string, string>>>.Write(beforeafterList, expHome + @"cprose\" + commit + @"\metadata_tool\before_after_locations" + seed + ".json");
        //            var beforeafterListAll = ConvertBeforeAfterToRegions(beforeafter);
        //            JsonUtil<List<Tuple<Region, string, string>>>.Write(beforeafterListAll, expHome + @"cprose\" + commit + @"\metadata_tool\before_after_locationsAll" + seed + ".json");
        //            //Comparing edited locations with baseline
        //            var baselineBeforeAfterList = JsonUtil<List<Tuple<Region, string, string>>>.Read(expHome + @"cprose\" + commit + @"\metadata\before_after_locations" + seed + ".json");
        //            var firstIncorrect = GetFirstIncorrect(beforeafterList, baselineBeforeAfterList, randomList, locations);
        //            if (firstIncorrect == -1)
        //            {
        //                GenerateDiffBeforeAfter(beforeafter, commit);
        //                break;
        //            }

        //            firstProblematicLocation = firstIncorrect;
        //        }
        //        if (examples.Contains(firstProblematicLocation))
        //        {
        //            GenerateDiffBeforeAfter(beforeafter, commit);
        //            throw new Exception("A BeforeAfter could not be learned using this examples.");
        //        }
        //        examples.Add(firstProblematicLocation);
        //    }

        //    var sizes = scriptsizes.Split(new[] { "\n" }, StringSplitOptions.None).Select(o => Int32.Parse(o));
        //    var mean = sizes.Average();
        //    //Execution end

        //    long totalTimeToLearn = helper.TotalTimeToLearn;
        //    long totalTimeToExecute = helper.TotalTimeToLearn;
        //    var transformed = helper.Transformed;
        //    var program = helper.Program;
        //    var dictionarySelection = helper.DictionarySelection;

        //    Log(commit, 
        //        totalTimeToLearn + totalTimeToExecute, 
        //        examples.Count,
        //        regions.Count,
        //        transformed.Count,
        //        dictionarySelection.Count,
        //        program.ToString(),
        //        totalTimeToLearn,
        //        totalTimeToExecute,
        //        mean);
        //    return true;
        //}

        /// <summary>
        /// Complete test
        /// </summary>
        /// <param name="commit">Commit where the change occurs</param>
        /// <returns>True if pass test</returns>
        public static bool CompleteTestBase(string commit, string solutionPath = null, List<SyntaxKind> kinds = null)
        {
            if (kinds == null)
            {
                kinds = new List<SyntaxKind> { SyntaxKind.MethodDeclaration, SyntaxKind.ConstructorDeclaration };
            }

            //Load grammar
            var grammar = GetGrammar();

            string expHome = Environment.GetEnvironmentVariable("EXP_HOME", EnvironmentVariableTarget.User);
            var codeTransformations = JsonUtil<List<CodeTransformation>>.Read(expHome + @"cprose\" + commit + @"\metadata\transformed_locations.json");

            List<Region> regions = codeTransformations.Select(entry => entry.Trans).ToList();
            var locations = codeTransformations.Select(entry => entry.Location).ToList();
            var globalTransformations = RegionManager.GetInstance().GroupTransformationsBySourcePath(codeTransformations);

            //Random number generator with a seed.
            int seed = 86028157;
            Random random = new Random(seed);
            var randomList = Enumerable.Range(0, locations.Count).OrderBy(o => random.Next()).ToList();
            var examples = randomList.GetRange(0, 2);

            //Execution
            TestHelper helper;
            examples.Sort();
            helper = new TestHelper(grammar, regions, locations, globalTransformations, expHome, solutionPath, commit, kinds, seed);
            var allPrograms = helper.LearnPrograms(examples);

            for (var i = 1; i <= allPrograms.Count; i++)
            {
                var p = allPrograms[i - 1];
                helper.Execute(examples, p);

                string codeFragments = "codefragments";
                var fragments = GetDataAndSaveToFile(commit, expHome, seed, codeFragments);
                var regionsFrags = ConvertFragmentsToRegions(fragments);
                JsonUtil<List<Region>>.Write(regionsFrags,
                    expHome + @"cprose\" + commit + @"\metadata\transformed_locationsAll" + seed + ".json");

                string beforeafter = "beforeafter";
                beforeafter = GetDataAndSaveToFile(commit, expHome, seed, beforeafter);

                var foundLocations = GetEditedLocations(fragments, locations);
                var firstProblematicLocation = GetFirstNotFound(foundLocations, locations, randomList);

                if (firstProblematicLocation == -1)
                {
                    //Generate meta-data for BaselineBeforeAfterList on commit.
                    var foundList = GetEditionInLocations(fragments, locations);
                    JsonUtil<List<Region>>.Write(foundList,
                        expHome + @"cprose\" + commit + @"\metadata_tool\transformed_locations" + seed + ".json");

                    var beforeafterList = GetBeforeAfterData(beforeafter, locations);
                    JsonUtil<List<Tuple<Region, string, string>>>.Write(beforeafterList,
                        expHome + @"cprose\" + commit + @"\metadata_tool\before_after_locations" + seed + ".json");
                    var beforeafterListAll = ConvertBeforeAfterToRegions(beforeafter);
                    JsonUtil<List<Tuple<Region, string, string>>>.Write(beforeafterListAll,
                        expHome + @"cprose\" + commit + @"\metadata_tool\before_after_locationsAll" + seed + ".json");
                    //Comparing edited locations with baseline
                    var baselineBeforeAfterList =
                        JsonUtil<List<Tuple<Region, string, string>>>.Read(expHome + @"cprose\" + commit +
                                                                            @"\metadata\before_after_locations" +
                                                                            seed + ".json");
                    var firstIncorrect = GetFirstIncorrect(beforeafterList, baselineBeforeAfterList, randomList,
                        locations);
                    if (firstIncorrect == -1)
                    {
                        LogProgram(commit, i, p.ToString(), true);
                    }
                    else
                    {
                        LogProgram(commit, i, p.ToString(), false);
                    }
                }
                else
                {
                    LogProgram(commit, i, p.ToString(), false);
                }
            }
            return true;
        }

        private static int GetFirstIncorrect(List<Tuple<Region, string, string>> toolBeforeAfterList, List<Tuple<Region, string, string>> baselineBeforeAfterList, List<int> randomList, List<CodeLocation> locations)
        {
            //computing list of locations that do not follow the baseline.
            var notFoundList = baselineBeforeAfterList.Where(o => !toolBeforeAfterList.Contains(o)).ToList();
            if (!notFoundList.Any()) return -1;
            //Computing example locations that do not follow the baseline.
            var incorrectLocationsList = locations.Where(o => notFoundList.Any(e => o.Region.IntersectWith(e.Item1)));
            //Computing the index of the locations that do not follow the baseline.
            var notFoundIndexList = incorrectLocationsList.Select(o => locations.IndexOf(o));
            //Getting the index of the location in the random list.
            var index = randomList.FindIndex(o => notFoundIndexList.Contains(o));
            var firstNotFound = randomList[index];
            return firstNotFound;
        }

        private static List<Tuple<Region, string, string>> GetBeforeAfterData(string beforeafter, List<CodeLocation> locations)
        {
            var regions = ConvertBeforeAfterToRegions(beforeafter);
            var dictionary = CreateDictionaryMatch(locations, regions.Select(o => o.Item1).ToList());

            var foundList = new List<Region>();
            dictionary.Values.ForEach(o => foundList.AddRange(o));
            foundList = foundList.Distinct().ToList();

            var regionsFound = regions.Where(o => foundList.Contains(o.Item1)).ToList();
            return regionsFound;
        }

        private static void GenerateDiffBeforeAfter(string beforeafter, string commit)
        {
            var regions = ConvertBeforeAfterToRegions(beforeafter);
            var groups = regions.GroupBy(o => o.Item3);
            var dic = groups.ToDictionary(group => group.Key, group => group.ToList());

            string expHome = Environment.GetEnvironmentVariable("EXP_HOME", EnvironmentVariableTarget.User);
            var transmedList = Transform(dic);
            string output = "";
            string errors = "";
            var pathoutput = Path.Combine(expHome, @"cprose\", commit + @"\metadata\diff.df");
            foreach (var ba in transmedList)
            {
                var className = ba.Item3.Split(@"\".ToCharArray()).Last();
                var pathb = Path.Combine(expHome, @"cprose\", commit + @"\metadata_tool\B" + className);
                var patha = Path.Combine(expHome, @"cprose\", commit + @"\metadata_tool\A" + className);
                FileUtil.WriteToFile(pathb, ba.Item1);
                FileUtil.WriteToFile(patha, ba.Item2);

                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = $"/C diff {pathb} {patha} -U5";
                process.StartInfo = startInfo;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.Start();

                output += process.StandardOutput.ReadToEnd();
                errors += process.StandardError.ReadToEnd();
            }

            if (!output.IsEmpty())
            {
                FileUtil.WriteToFile(pathoutput, output);
            }
            else if (!errors.IsEmpty())
            {
                FileUtil.WriteToFile(pathoutput, errors);
            }
            else
            {
                FileUtil.WriteToFile(pathoutput, "Occurs an error while running process.");
            }
        }

        public static List<Tuple<string, string, string>> Transform(Dictionary<string, List<Tuple<Region, string, string>>> transformations)
        {
            List<Tuple<string, string, string>> tRegions = new List<Tuple<string, string, string>>();
            foreach (var item in transformations)
            {
                int nextStart = 0;
                var filePath = item.Value.First().Item3;
                var source = File.ReadAllText(filePath);
                string sourceCode = source;
                foreach (var tregion in item.Value)
                {
                    Region region = tregion.Item1;
                    string BeforeAfter = tregion.Item2;

                    int start = nextStart + region.Start;
                    int end = start + region.Length;
                    var sourceCodeUntilStart = sourceCode.Substring(0, start);
                    var sourceCodeAfterSelection = sourceCode.Substring(end);
                    sourceCode = sourceCodeUntilStart + BeforeAfter + sourceCodeAfterSelection;

                    nextStart += BeforeAfter.Length - region.Length;
                }
                tRegions.Add(Tuple.Create(source, sourceCode, filePath));
            }
            return tRegions;
        }

        private static List<Tuple<Region, string, string>> ConvertBeforeAfterToRegions(string beforeafter)
        {
            var regions = new List<Tuple<Region, string, string>>();
            var enumerator = beforeafter.Split(new[] { "EndLine" }, StringSplitOptions.None).GetEnumerator();
            while (enumerator.MoveNext())
            {
                if ((enumerator.Current + "").Equals("")) break;

                int start = Int32.Parse(enumerator.Current + "");
                enumerator.MoveNext();
                int length = Int32.Parse(enumerator.Current + "");
                enumerator.MoveNext();
                string content = enumerator.Current + "";
                enumerator.MoveNext();
                string after = enumerator.Current + "";
                enumerator.MoveNext();
                string path = enumerator.Current + "";

                var region = new Region();
                region.Start = start;
                region.Length = length;
                region.Text = content;
                region.Path = path;

                regions.Add(Tuple.Create(region, after, path));
            }
            return regions;
        }

        private static string GetDataAndSaveToFile(string commit, string expHome, int seed, string fileName)
        {
            string file = expHome + fileName + ".txt";
            var fragments = FileUtil.ReadFile(file);
            FileUtil.WriteToFile(expHome + @"cprose\" + commit + @"\" + fileName + seed + ".res", fragments);
            File.Delete(file);
            return fragments;
        }

        private static int GetFirstNotFound(List<CodeLocation> foundLocations, List<CodeLocation> locations, List<int> result)
        {
            var notFoundList = locations.Where(o => !foundLocations.Contains(o)).ToList();
            if (!notFoundList.Any()) return -1;

            var notFoundIndexList = notFoundList.Select(o => locations.IndexOf(o));
            var index = result.FindIndex(o => notFoundIndexList.Contains(o));
            var firstNotFound = result[index];
            return firstNotFound;
        }

        private static List<CodeLocation> GetEditedLocations(string fragments, List<CodeLocation> locations)
        {
            var regions = ConvertFragmentsToRegions(fragments);
            var dictionary = CreateDictionaryMatch(locations, regions);

            var found = dictionary.Where(o => o.Value.Any()).Select(o => o.Key).ToList();
            return found;
        }

        private static List<Region> GetEditionInLocations(string fragments, List<CodeLocation> locations)
        {
            var regions = ConvertFragmentsToRegions(fragments);
            var dictionary = CreateDictionaryMatch(locations, regions);

            var foundList = new List<Region>();
            dictionary.Values.ForEach(o => foundList.AddRange(o));
            foundList = foundList.Distinct().ToList();
            return foundList;
        }

        private static Dictionary<CodeLocation, List<Region>> CreateDictionaryMatch(List<CodeLocation> locations, List<Region> regions)
        {
            var dictionary = new Dictionary<CodeLocation, List<Region>>();
            foreach (var v in locations)
            {
                var matches = regions.Where(o => v.Region.IntersectWith(o));
                if (!dictionary.ContainsKey(v))
                {
                    dictionary[v] = new List<Region>();
                }
                dictionary[v].AddRange(matches);
            }
            return dictionary;
        }

        private static List<Region> ConvertFragmentsToRegions(string fragments)
        {
            var regions = new List<Region>();
            var enumerator = fragments.Split(new[] { "EndLine" }, StringSplitOptions.None).GetEnumerator();
            while (enumerator.MoveNext())
            {
                if ((enumerator.Current + "").Equals("")) break;

                int start = Int32.Parse(enumerator.Current + "");
                enumerator.MoveNext();
                int length = Int32.Parse(enumerator.Current + "");
                enumerator.MoveNext();
                string content = enumerator.Current + "";
                enumerator.MoveNext();
                string path = enumerator.Current + "";

                var region = new Region();
                region.Start = start;
                region.Length = length;
                region.Text = content;
                region.Path = path;

                regions.Add(region);
            }
            return regions;
        }

        public static void Log(string commit, double time, int exTransformations, int locations, int acTrasnformation,
            int documents, string program, double timeToLearnEdit, double timeToTransformEdit, double mean)
        {
            string commitFirstLetter = commit.ElementAt(0).ToString();
            string commitId = commit.Substring(commit.IndexOf(@"\") + 1);

            commit = /*commitFirstLetter + "-" +*/ /*commitId;

            string path = TestUtil.LogPath;
            using (ExcelManager em = new ExcelManager())
            {

                em.Open(path);

                int empty;
                for (int i = 1; ; i++)
                {
                    if (em.GetValue("A" + i, Category.Formatted).ToString().Equals("") ||
                        em.GetValue("A" + i, Category.Formatted).ToString().Equals(commit))
                    {
                        empty = i;
                        break;
                    }
                }

                em.SetValue("A" + empty, commit);
                em.SetValue("B" + empty, time / 1000);
                em.SetValue("C" + empty, exTransformations);
                em.SetValue("D" + empty, locations);
                em.SetValue("E" + empty, acTrasnformation);
                em.SetValue("F" + empty, documents);
                em.SetValue("G" + empty, program);
                em.SetValue("H" + empty, timeToLearnEdit / 1000);
                em.SetValue("I" + empty, timeToTransformEdit / 1000);
                em.SetValue("J" + empty, mean);
                em.Save();
            }
        }


        public static void LogProgram(string commit, int programIndex, string program, bool status)
        {
            string commitFirstLetter = commit.ElementAt(0).ToString();
            string commitId = commit.Substring(commit.IndexOf(@"\") + 1);

            commit = commitId;

            string path = TestUtil.LogProgramStatus;
            using (ExcelManager em = new ExcelManager())
            {
                em.Open(path);

                int empty;
                for (int i = 1; ; i++)
                {
                    if (em.GetValue("A" + i, Category.Formatted).ToString().Equals("") ||
                        em.GetValue("A" + i, Category.Formatted).ToString().Equals(commit) && em.GetValue("B" + i, Category.Formatted).ToString().Equals(programIndex.ToString()))
                    {
                        empty = i;
                        break;
                    }
                }

                em.SetValue("A" + empty, commit);
                em.SetValue("B" + empty, programIndex);
                em.SetValue("C" + empty, program);
                em.SetValue("D" + empty, status);
                em.Save();
            }
        }
    }
}

*/

