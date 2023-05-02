# 「CodeBook」
# ポートフォリオサイト概要(サイト停止中です)
プログラミング書籍販売サイト  
![codebook (1)](https://user-images.githubusercontent.com/59566529/138570228-0af6df43-fdad-477f-b244-135f0c91f576.png)

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
* カード番号: 4242424242424242
    
リソース削除:
```bash
$ docker-compose down 
$ docker stop $(docker ps -q)
$ docker rm $(docker ps -q -a)
$ docker rmi $(docker images -q)
$ docker volume rm $(docker volume ls -qf dangling=true)
$ docker volume ls -qf dangling=true | xargs -r docker volume rm
```
