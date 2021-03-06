### E-Tr/ee
- 長さnの文字列sが与えられる、以下の条件を満たすn頂点の木は存在するか？
  -  各頂点には1,2,...,nの番号がついている
  -  各辺には1,2,...,n-1の番号がつけられていて、i番目の辺は頂点uiとviをつないでいる
  -  sのi番目の文字が'1'であるとき、木からある辺を1つ取り除くことで、サイズiの連結成分が作れる
  -  sのi番目の文字が'0'であるとき、木からどのように辺を一つ取り除いてもサイズiの連結成分が作れない
- 問題に再度向き合ってむきあってみよう
  - どこか一つを取り除くことで、サイズsとn-sの連結成分を作ることが出来る
    - なので、**サイズiが1の時n-iは共に1でなければならない**
      - 逆も同じ
        - なので、s[i]!=s[n-i]である場合は'-1'
      - これを**1.**とする
  - むろんsn=1はアウト
  - ここまで来たら、iはi<=n/2まで考えれば良いということも分かる
    - n-iはサイズiの木が出来れば良いので
  - 0をベースにするか1をベースにするかを考える
    - ある連結成分を作ろうとしたら、
      - **その辺を取り除くとiとn-iの辺の集合になる**
      - となることなので、木として考えるならば
        - サイズiの部分木を作るということである
          - サイズ1の部分木を作りたい時
            - 頂点を一つ用意し、辺を伸ばす
          - サイズ2の部分木を作りたい時
            - サイズ1の頂点から伸びた辺に頂点を接続し、辺を伸ばす
          - サイズ2の部分木を作りたくないとき
            - サイズ1の頂点から伸びた辺に頂点を接続しないようにする
          - 紙に書こう
            - ACした、前は部分木で考えなかったが、部分木で考えたらすんなり
            - あと、紙に書いたのも大きいが、段階を踏むように書いたら分かりやすかった
              - - 樹形図っぽく書いたので「**樹形図法**」で良いか
            - 思考のフォーマット「**部分木フォーマット**」
             
### F - I hate Shortest Path Problem

- 問題
    - h,wのグリッド
    - 上からiマス目のli,riから下には行けない
    - 各マスからは右か下に移動可能
    - スタート地点は1行目
    - 1行目の何列目からスタートしても良い
    - i+1行目にたどりつくまでの最短経路は？
    - 存在しない場合は-1を表示
- 考察
    - 各行において、li,riは一つだけという特徴
    - liかriを中心に見てみる？
      - 区間スケジューリングをして、liとriの間が1でも空いていたら、全て最短距離で辿り着ける
    - 範囲外を見てみる
      - すると1行目は0~2箇所の範囲で下に行くことが出来る
        - その下に行くことが出来た場所のコスト(c)1は
      - 
    - ある範囲において、最短箇所が左側の方が小さい時
      - 考えようとしたが筋が悪そう
    - 辺を貼るにも量が多すぎる
      - 右から左には戻れない？
        - 戻れない
      - 範囲の上に落ちた場合、その下に行くための最短は
        - ri-落ちた位置+1となるのは間違いない

---
### B - Extension
  - https://atcoder.jp/contests/agc046/tasks/agc046_b
  - A*Bのマス目
    - 全てのマス目は白く塗られている
    - 縦または横を選びマス目を一行または一列追加する
    - 追加されたマスのうち1マスを黒く塗り、残りのマスを白く塗る
  - 追加しながら処理しようとすると、ダブルカウントしてしまう
    - ダブルカウントをうまいこと弾く必要がある
    - 最終的な盤面の塗られ方ということだが、外から処理するようにしても良いとは思っている
  - 2 1 3 4 = 65
    - o
    - o
      - という状態から開始し
    - xxxx
    - xxxx
    - xxxx
      - まで操作する
    - x
    - o
    - o
      - から
    - 回数nとしてマス目総数pとしてpCnでは？
  - 結局分からなかったので解説を見てみたが、かなり自分の実力と差があるようだ
    - 広い範囲では数学の実力であろう
    - 更に広くすると思考能力である
  - 