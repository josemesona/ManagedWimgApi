﻿using NUnit.Framework;
using Shouldly;
using System;

// ReSharper disable UnusedVariable

namespace Microsoft.Wim.Tests
{
    [TestFixture]
    public class CommitImageHandleTests : TestBase
    {
        [Test]
        public void CommitImageHandleTest()
        {
            using (WimHandle imageHandle = WimgApi.LoadImage(TestWimHandle, 1))
            {
                WimgApi.MountImage(imageHandle, MountPath, WimMountImageOptions.Fast | WimMountImageOptions.DisableDirectoryAcl | WimMountImageOptions.DisableFileAcl | WimMountImageOptions.DisableRPFix);

                try
                {
                    using (WimHandle newImageHandle = WimgApi.CommitImageHandle(imageHandle, false, WimCommitImageOptions.DisableDirectoryAcl | WimCommitImageOptions.DisableFileAcl | WimCommitImageOptions.DisableRPFix))
                    {
                        WimgApi.GetImageCount(TestWimHandle).ShouldBe(TestWimImageCount);
                    }
                }
                finally
                {
                    WimgApi.UnmountImage(imageHandle);
                }
            }
        }

        [Test]
        public void CommitImageHandleTest_Append()
        {
            using (WimHandle imageHandle = WimgApi.LoadImage(TestWimHandle, 1))
            {
                WimgApi.MountImage(imageHandle, MountPath, WimMountImageOptions.Fast | WimMountImageOptions.DisableDirectoryAcl | WimMountImageOptions.DisableFileAcl | WimMountImageOptions.DisableRPFix);

                try
                {
                    using (WimHandle newImageHandle = WimgApi.CommitImageHandle(imageHandle, true, WimCommitImageOptions.DisableDirectoryAcl | WimCommitImageOptions.DisableFileAcl | WimCommitImageOptions.DisableRPFix))
                    {
                        WimgApi.GetImageCount(TestWimHandle).ShouldBe(TestWimImageCount + 1);
                    }
                }
                finally
                {
                    WimgApi.UnmountImage(imageHandle);
                }
            }
        }

        [Test]
        public void CommitImageHandleTest_ThrowsArgumentNullException_imageHandle()
        {
            ShouldThrow<ArgumentNullException>("imageHandle", () =>
                WimgApi.CommitImageHandle(null, false, WimCommitImageOptions.None));
        }
    }
}