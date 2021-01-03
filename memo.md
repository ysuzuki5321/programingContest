<script async src="https://cdnjs.cloudflare.com/ajax/libs/mathjax/2.7.0/MathJax.js?config=TeX-AMS_CHTML"></script>
<script type="text/x-mathjax-config">
 MathJax.Hub.Config({
 tex2jax: {
 inlineMath: [["\\(","\\)"] ],
 displayMath: [ ['$$','$$'], ["\\[","\\]"] ]
 }
 });
</script>

- ある数に13を足すと11で割り切れ、11を足すと13で割り切れる、このような自然数のうち2番目に小さいものを求めよ
  - １番目に小さいのを求められればそこからは周期法で確認可能
	- この問題の核は１番目に小さいものを見つけるところである
		- ...１番目に小さいものを見つけるというのは不定方程式のax+by=1でも同じ、単位に分解するのも広い範囲では当てはまるだろう
		- ...考察には順序があると考えられる→これに名前をつけたい
			- ...「**考察ステップ**」
			- ...一番小さいものを見つける事を何と言おうか
				- ...先頭を特定する事であるから「**先頭特定**」と名づける
		- 一番小さい物を見つけるのが難しい
			- 11+13を足すことにより両方で割れるということに気が付くためには、一つステップが必要
				- ある数をxとし
					- x+13=11a+0
					- x+11=13a+0
						- とまず考え、次に
						- x+13+11=11a+0∴x+24=11a
						- x+11+13=13b+0∴x+24=13b
							- と一つ余計にステップさせる、これは答えが分かっているから導けるが、
							- 実践で行うには名前をつけて身に着ける必要がある
								- 「**もう一回法**」と名付けよう、分かりやすい方が良い
								- 11a=13bとなる両方で割り切れる数は11,13は互いに素であるため、143となる
	- 式にするのは「**立式法**」である、とにかくメソッドが必要だ							
		- この問題は立式法で立式し、**"共通点を見つけ"**、もう一回法で先頭特定し、周期法で見つけるという手順が必要だ
			- 共通点を見つける事にも名前をつけたい、どのような共通点かにもよるのだが、
				- この問題であれば「**共通数字抽出法**」が妥当っぽい
					- かなり応用範囲が広いメソッドだろう
						- 考察に関して考えるのはなかなかの思考体力を使用する
---
- https://atcoder.jp/contests/abc170/tasks/abc170_f
  - この問題では、ある場所にぶつかるまで移動可能な動き方をするようにステップさせることが出来る
    - この時、ダイクストラの一度の移動で突き当たりに到達するまでqueueに入れてしまう事により無事TLEをしてしまっていた。
    - 実際は一歩分だけステップさせれば良かったわけであるが、一度頭に入るとその動きのみを追い求めてしまう事がある
      - このような思考の傾向はこの問題だけではなく他でも散々出会っているが、なかなか直らない
        - この癖を直す必要がある、ということで、最初に読んだ印象を引きずってしまう事に名前をつけ、直す練習をしよう
          - 別の道が見えなくなる感じであるため
        - 「**盲目思考**」とでも名づけよう
        - 果たしてこの盲目思考を脱却することが出来るか。。。
          - これを脱却出来ると、なんとなくAtCoder黄色になれる程度の頭が出来上がる気はする
          - これはあくまでも癖なのである
        - この癖を直すのは試行錯誤の方法とも考えられる
          - 癖は**訓練の結果**であるため、正解に直接辿り着けるような場合はかなりの速度で到達可能である
          - しかし間違っている時に盲目思考となり、窮地に追いやられる
			- 競技プログラミングやこの世界で何か頭を使うような事を行うとき、確かに速さは必要なのだが、**方向転換**出来ないとそのまま時間がすぎていく事になる
				- これに対応するためのものだ
	
---
- なぞなぞ的な発想も必要となる時がある気がする
  - 時計〇△□時計〇〇時計という問題
  - ごぜん、ごごが入るのだが、全部絵だと、時計部分も日本語で読もうとしてしまう。
    - これも癖である
		
---
- 必要条件から絞り込む、に関してはここで把握しておくべきテクニックが色々とある
  - 1.では、変数を一つ減らすと、9x+5y=60という形の式になる
    - ここで9x=60-5yと移行し、9x=5(12-y)と変換すると、xが5の倍数ということになるのだ、両辺を割るという固定観念しかなかったので、このような考え方が出来るわけもなく
    - 上のようにすると見事にx=5と求められる、

---
- 連続した数を見つけられるか、これも経験と意識によって克服可能であろう
  - 連続した数は特徴がある事が多いと考えられる

---
- 1111の倍数になるというマスターオブ場合の数の合同の問題
  - 立式したものをmod2とmod3で考えるようにするという展開につなげると、求められるのだが、
  - そこまで考えることがまだ難しい
---
- 証明の手法は様々存在するのに、これに名前がついていない
  - ある式1からある式2に変換する手法、基本的には1から2の式の**形**にするので、形を近づけるということで、
    - 「**形近似**」と名づけよう
  - マスター・オブ・整数のx+zをyで割った余りが1,y+zをxで割った余りが1,x+yをzで割った余りが1の問題
    - z<=y<=xと決まっていて、y+z=x+1であるところまではスムーズだが、この後は「割った余り」で思考が飛躍し
    - x+z=ya+1について考えてしまう、あるところまでは合うのだが、厳密解を求めるには弱い
      - 解説ではy+z=x+1を式変形しそれぞれ展開させていた
      - 一度飛躍がないか要検討するため、または注意深く一度立ち止まるために名前をつけよう
        - 確認をするために必要な方法なので「**現場猫法**」
---
- ax+by型の整数と、一次の不定方程式
  - 問6の考え方
  - 3x+5yが11で割り切れるような自然数の組(x,y)の集合と、2x+7yが11で割り切れるような自然数の組(x,y)の集合は一致することを示せ。
    - まず3x+5yを2x+7yに近づけるようにするのだが、解法を見ると以下のようなステップになっている
      - 3x+5y=11mを2倍する
      - 6x+10y=22mの両辺に11yを足す
      - 6x+21y=22m+11yとなる
      - 右辺は11の倍数で、左辺を3で割ると$ 2x+7y $が現れるという寸法である
       	- このやりかたで2x+7y=11mから3x+5yに近づける事も出来るだろう
        - 10x+35y=55m
        - 21x+35y=55m+11x
        - となる
    - ステップは変換先と同じ素因数を持つように倍にして、倍数が維持されるように足している
      - 「**倍数維持法**」としてみよう、倍数を維持しながら式を色々いじってみる
        - ゴールがどこかを見ると更に良い方法となりそうだ
        - また、**集合は一致する**、をそれぞれの式へと移行させるのはどこかの証明方法で見たような気もする
        - 特にスタサプで見たかな、再確認したいところである

---
- マスター・オブ・整数より
  - 素因数分解の利用2の研究問題
  - $ 3^{m}-1 $ (mは自然数)について、次の各問いに答えよ
    1. mが奇数の時 $ 3^{m}-1 $ を素因数分解したときの2の指数は何か
    1. mが奇数の時 $ 3^{m}+1 $ を素因数分解したときの2の指数は何か
    1. $ 3^{240}-1 $ を素因数分解したときの２の指数は何か
      - という問題である
      - まず、次数が変数ということで、なんとなく、「ある数に決まるんだろうな」と考える
      - 次に色々な$ 3^{m} $で考える、$ 3,3^{2},3^{3} $等
        - mが奇数なので、$ 3^{1},3^{3} $等を-1,+1してみるという実験をする
        - この方法では**全ての奇数mについて同じ事が言えるか不明**
        - この時点でmを偶数と3一つに分解して考えられなければ解けない
          - $ 3^{2}*3 $でmが奇数の式を単純化出来る
          - $ 3^{2}≡1 mod 8 $であり、mが奇数であれば$3mod8$となるわけだ
            - 2点難しい
              - mを偶数と3一つに分解する事
              - mod 8で考える事
            - これを分析したい
              - よくある手法なのだが、問題文を読んでも導けない
              - 手順としてはmを偶数と3一つに分解する方が先で、$ 3^{2} $に気が付ければ、$mod8 $を使用する事は出来そうな気はする
                - これは「**奇数換言法**」と言ってしまおう
                - 分解したら、それぞれの数字を見て考えるわけだが、mod 8は余り1に出来る数字ということで、発想的にはこっちが優先だろう
            - 余り1にするのを「**倍数単純化**」と名づける、偶数→奇数でも同じ事が言えるか？
              - $ 2^{m} $の偶奇を見た同じ問題が出たとする
              - mが奇数の時？
                - $ 2^{2} = 4 $なので、余り1にしようとすると3で割った余りとなり、2を掛けるので、3で割った余りが2となる
                - 全く同じ状態となる、素晴らしい

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
---
D - Leaping Tak
https://atcoder.jp/contests/abc179/tasks/abc179_d
    - dpな気もしたが、o(n^2)になってしまうため考える
        - 例1を見ると微妙な事に気が付く{1,3,4}なのに、3,4,5という動きがない
            - 間違い、処理しきれていた
                - 使うものが異なればそれらは被らない？
        - この手のものは左だけと右だけで考えるのをよくやる

---
- 自分の弱点について
  - 解けなかった問題からは得られる物が多いはずである。
    - その弱点をまとめる
      - https://atcoder.jp/contests/abc179/tasks/abc179_d
      - 上の問題は累積和とdpの組み合わせなのだが、その動きが見えていない
        - dpに累積和が重なるので、遷移があやふやになってしまう
        

--- 
- √(n^2+99)が整数となるような自然数ｎの値を全て求めよ
  - ちゃんとやろうとしたら解けなかった
    - 思考が悪かったと言える
      - 先入観によって全ての場合を試していなかった。
        - **n=xと答えを求めるという癖**によるものである
      - 答えは√(n^2+99) = mと置いてn^2+99 = m^2
        - から99=m^2-n^2
          - 99=(m+n)(m-n)
            - としてnを求める必要がある
              - 思考の癖に足を引っ張られn=として求めようとしたので、求められなかった
        - 油断もあるので、ここで名前をつけておくことにしよう
          - a=Answerとしこのaを検討するパターンが固定されて身動き取れなくなってしまうということである
            - アンチパターンとして考えられる分けで、これらにも名前をつけておきたい
            - 「**A固定**」と置いておく

--- 
数式書くとき
   $$ e^{i x} = \cos{x} + i \sin{x} $$
   ##  $ \varepsilon - \delta $ 論法
任意の $ \varepsilon > 0 $ についてある $ \delta > 0 $ が存在して、任意の $ x \in \mathbb{R} $ に対して $ 0 < |x - a| < \delta $ ならば $ |f(x) - f(a)| < \varepsilon $ を満たすとき $ f(x) $ は $ a $ で連続であるという。