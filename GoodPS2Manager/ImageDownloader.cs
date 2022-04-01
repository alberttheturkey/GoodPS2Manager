﻿using System;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http;
using System.Collections.Generic;

namespace GoodPS2Manager
{
    // Image downloader code here is implemented from the example provided by MarcusOtter here
    // https://gist.github.com/MarcusOtter/b9b4ee3fc7be04469fd20480daa86c38
    // Thanks Marcus!
    public interface IImageDownloader
    {
        Task DownloadImageAsync(string directoryPath, string fileName, Uri uri);
    }

    public class ImageDownloader : IImageDownloader, IDisposable
    {
        private bool _disposed;
        private readonly HttpClient _httpClient;

        public ImageDownloader(HttpClient httpClient = null)
        {
            _httpClient = httpClient ?? new HttpClient();
        }

        /// <summary>
        /// Downloads an image asynchronously from the <paramref name="uri"/> and places it in the specified <paramref name="directoryPath"/> with the specified <paramref name="fileName"/>.
        /// </summary>
        /// <param name="directoryPath">The relative or absolute path to the directory to place the image in.</param>
        /// <param name="fileName">The name of the file without the file extension.</param>
        /// <param name="uri">The URI for the image to download.</param>
        public async Task DownloadImageAsync(string directoryPath, string fileName, Uri uri)
        {
            if (_disposed) { throw new ObjectDisposedException(GetType().FullName); }

            // Get the file extension
            var uriWithoutQuery = uri.GetLeftPart(UriPartial.Path);
            var fileExtension = Path.GetExtension(uriWithoutQuery);

            // Create file path and ensure directory exists
            var path = Path.Combine(directoryPath, $"{fileName}{fileExtension}");
            Directory.CreateDirectory(directoryPath);

            // Download the image and write to the file
            var imageBytes = await _httpClient.GetByteArrayAsync(uri);

            // Modified to work with .Net Framework instead of .Net Core
            // Because I dunno, I'm dumb
            using FileStream stream = File.Create(path);
            await stream.WriteAsync(imageBytes, 0, (int)stream.Length);
        }

        public void Dispose()
        {
            if (_disposed) { return; }
            _httpClient.Dispose();
            GC.SuppressFinalize(this);
            _disposed = true;
        }

    }

    public class GameArtDownloader : ImageDownloader
    {
        public Dictionary<string,string> imageFileList;
        public GameArtDownloader(HttpClient httpClient = null) : base(httpClient)
        {

        }

        public GameArtDownloader(string gameID)
        {

        }
    }
}
