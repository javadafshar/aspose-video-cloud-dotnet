﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Aspose" file="GetVideoPropertiesTest.cs">
// //   Copyright (c) 2018 Aspose.Video for Cloud
// // </copyright>
// // <summary>
// //   Permission is hereby granted, free of charge, to any person obtaining a copy
// //  of this software and associated documentation files (the "Software"), to deal
// //  in the Software without restriction, including without limitation the rights
// //  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// //  copies of the Software, and to permit persons to whom the Software is
// //  furnished to do so, subject to the following conditions:
// // 
// //  The above copyright notice and this permission notice shall be included in all
// //  copies or substantial portions of the Software.
// // 
// //  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// //  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// //  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// //  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// //  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// //  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// //  SOFTWARE.
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------

namespace Aspose.Video.Cloud.Sdk.Tests.Video
{
    using System.IO;

    using Aspose.Video.Cloud.Sdk.Model;
    using Aspose.Video.Cloud.Sdk.Model.Requests;
    using Aspose.Video.Cloud.Sdk.Tests.Base;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Example of how to append document
    /// </summary>
    [TestClass]
    [DeploymentItem("TestData", "TestData")]
    public class GetVideoPropertiesTest : BaseTestContext
    {
        private readonly string dataFolder = Path.Combine(BaseTestDataPath, "VideoActions/GetVideo");
        /// <summary>
        /// Test get properties
        /// </summary>
        [TestMethod]
        public void TestGetVideoProperties()
        {
            var localName = "sample.avi";
            var remoteName = "TestGetVideo.avi";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.StorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir() + localName));
            var request = new GetVideoPropertiesRequest(remoteName, this.dataFolder);
            var actual = this.VideoApi.GetVideoProperties(request);

            Assert.AreEqual(200, System.Convert.ToInt32(actual.Code.ToString()));
            Assert.IsNotNull(actual.VideoProperties.List);
        }

        /// <summary>
        /// Test get property
        /// </summary>
        [TestMethod]
        public void TestGetVideoProperty()
        {
            var localName = "sample.avi";
            var remoteName = "TestGetVideoProperty.avi";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.StorageApi.PutCreate(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir() + localName));


            var request = new GetVideoPropertyRequest(remoteName, "duration", this.dataFolder);
            var actual = this.VideoApi.GetVideoProperty(request);

            Assert.AreEqual(200, System.Convert.ToInt32(actual.Code.ToString()));
            Assert.AreEqual("5000", actual.VideoProperty);
        }
    }
}