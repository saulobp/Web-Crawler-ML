using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace RobotMercadoLivre
{
    public static class ImageDownloader
    {
        public static void DownloadImagesFromUrl(string url, string folderImagesPath, Guid produtoId)
        {

            //div[contains(@class,'gallery-content item-gallery__wrapper')]


            var uri = new Uri(url);
            //var pages = new List<HtmlNode> { LoadHtmlDocument(uri) };
            DownloadImage(folderImagesPath, uri, produtoId);

            //pages.AddRange(LoadOtherPages(pages[0], url));

            //pages.SelectMany(p => p.SelectNodes("//a[@class='catalog__displayedItem__columnFotomainLnk']/img"))
            //     .Select(node => Tuple.Create(new UriBuilder(uri.Scheme, uri.Host, uri.Port, node.Attributes["src"].Value).Uri, new WebClient()))
            //     .AsParallel()
            //     .ForAll(t => DownloadImage(folderImagesPath, t.Item1, t.Item2,produtoId));
        }

        private static void DownloadImage(string folderImagesPath, Uri url,Guid produtoId)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFile(url, Path.Combine(folderImagesPath, Path.GetFileName(produtoId.ToString()+".jpg")));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static IEnumerable<HtmlNode> LoadOtherPages(HtmlNode firstPage, string url)
        {
            return Enumerable.Range(1, DiscoverTotalPages(firstPage))
                             .AsParallel()
                             .Select(i => LoadHtmlDocument(new Uri(url + "/?per_page=50&page=" + i)));
        }

        private static int DiscoverTotalPages(HtmlNode documentNode)
        {
            var totalItemsDescription = documentNode.SelectNodes("//div[@class='catalogItemList__numsInWiev']").First().InnerText.Trim();
            var totalItems = int.Parse(Regex.Match(totalItemsDescription, @"\d+$").ToString());
            var totalPages = (int)Math.Ceiling(totalItems / 50d);
            return totalPages;
        }

        private static HtmlNode LoadHtmlDocument(Uri uri)
        {
            var doc = new HtmlDocument();
            var wc = new WebClient();
            doc.LoadHtml(wc.DownloadString(uri));

            var documentNode = doc.DocumentNode;
            return documentNode;
        }
    }
}
