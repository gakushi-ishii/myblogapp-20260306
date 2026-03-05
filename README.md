# MyBlogApp 📝

ASP.NET Core MVC で構築されたシンプルなブログ閲覧アプリケーションです。

## 機能

- ブログ記事一覧の表示
- 個別記事の詳細表示
- タグによる記事分類
- レスポンシブデザイン（Bootstrap）

## 技術スタック

- **フレームワーク:** ASP.NET Core 8.0 (MVC)
- **ホスティング:** Azure Container Apps
- **CI/CD:** GitHub Actions
- **コンテナ:** Docker

## ローカル開発

```bash
cd MyBlogApp
dotnet run
```

http://localhost:5000 でアクセスできます。

## デプロイ

`main` ブランチにプッシュすると、GitHub Actions が自動で Azure Container Apps にデプロイします。

### ワークフローの流れ

1. ソースコードのチェックアウト
2. Azure へのログイン
3. `az containerapp up --source .` による ACR ビルド＆デプロイ

### 必要な GitHub Secrets

| シークレット名 | 説明 |
|---|---|
| `AZURE_CREDENTIALS` | Azure サービスプリンシパルの資格情報 (JSON) |

## ライブ URL

https://myblogapp.ambitiousbeach-3e9aa07e.japaneast.azurecontainerapps.io
