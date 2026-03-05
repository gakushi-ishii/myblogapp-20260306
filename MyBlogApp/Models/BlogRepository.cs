namespace MyBlogApp.Models;

public static class BlogRepository
{
    private static readonly List<BlogPost> Posts = new()
    {
        new BlogPost
        {
            Id = 1,
            Title = "ASP.NET Core で始めるWeb開発",
            Content = "ASP.NET Core は、クロスプラットフォームで動作するモダンな Web フレームワークです。\n\n" +
                      "C# を使って高速で安全な Web アプリケーションを構築できます。MVC パターンを採用しており、" +
                      "モデル・ビュー・コントローラーの分離により保守性の高いコードが書けます。\n\n" +
                      "このブログでは、ASP.NET Core を使った Web 開発の基礎から応用までを紹介していきます。" +
                      "まずは簡単な MVC アプリケーションの作成から始めましょう。",
            Author = "田中太郎",
            PublishedAt = new DateTime(2026, 3, 1),
            Tags = new List<string> { "C#", "ASP.NET Core", "Web開発" }
        },
        new BlogPost
        {
            Id = 2,
            Title = "GitHub Actions で CI/CD を自動化しよう",
            Content = "GitHub Actions は、GitHub に組み込まれた CI/CD プラットフォームです。\n\n" +
                      "リポジトリへのプッシュやプルリクエストをトリガーに、ビルド・テスト・デプロイを自動化できます。" +
                      "YAML ファイルでワークフローを定義し、さまざまなアクションを組み合わせることで、" +
                      "複雑なパイプラインも簡単に構築できます。\n\n" +
                      "Azure App Service へのデプロイも、公式のアクションを使えば数行の設定で完了します。",
            Author = "佐藤花子",
            PublishedAt = new DateTime(2026, 3, 3),
            Tags = new List<string> { "GitHub Actions", "CI/CD", "DevOps" }
        },
        new BlogPost
        {
            Id = 3,
            Title = "Azure App Service 入門ガイド",
            Content = "Azure App Service は、Web アプリケーションをホストするためのフルマネージドプラットフォームです。\n\n" +
                      "インフラの管理を Azure に任せ、開発者はアプリケーションのコードに集中できます。" +
                      "自動スケーリング、カスタムドメイン、SSL 証明書、認証など、" +
                      "エンタープライズレベルの機能が標準で提供されています。\n\n" +
                      ".NET、Node.js、Python、Java など多くのランタイムをサポートしており、" +
                      "Docker コンテナのデプロイにも対応しています。",
            Author = "鈴木一郎",
            PublishedAt = new DateTime(2026, 3, 5),
            Tags = new List<string> { "Azure", "App Service", "クラウド" }
        }
    };

    public static List<BlogPost> GetAll() => Posts.OrderByDescending(p => p.PublishedAt).ToList();

    public static BlogPost? GetById(int id) => Posts.FirstOrDefault(p => p.Id == id);
}
