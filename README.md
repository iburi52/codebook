# 「CodeBook」
# ポートフォリオサイト概要
プログラミング書籍販売サイト  

## 使用した技術一覧
* フロントエンド：angular, JavaScript
* バックエンド  ：.NET, C#
* インフラ     ：DigitalOcean, docer(docker-compose)

## 機能一覧
* ユーザ認証機能
* 商品検索、カテゴリ検索、ソート機能
* 外部API(支払い処理)連携
* 購入履歴閲覧機能

### docker-composeを使用してアプリケーション実行

インフラ起動:
```bash
$ docker-compose up 
```
フロントエンド起動:
```bash
$ cd client
$ npm install
$ ng serve  
```
バックエンド起動:
```bash
$ cd API
$ dotnet run
```
localサイトにアクセス:[https://localhost:4200/](https://localhost:4200/)  
テストユーザ：  
* emaill: test@test.com
* password: Password1¥
    
リソース削除:
```bash
$ docker-compose down 
$ docker stop $(docker ps -q)
$ docker rm $(docker ps -q -a)
$ docker rmi $(docker images -q)
$ docker volume rm $(docker volume ls -qf dangling=true)
$ docker volume ls -qf dangling=true | xargs -r docker volume rm
```
