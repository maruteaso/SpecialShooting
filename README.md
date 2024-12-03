# SpecialShooting
こちらはUnityで制作した2Dシューティングゲームのプロジェクトファイルです。

開発バージョン：Unity 2017.3.1f1 Personal(64bit)

## 概要
このゲームは、10体のボスを順に倒していくという流れになっています。プレイヤーは一度でも弾に当たると破壊されゲームオーバーとなります。（その時のボスからやり直せます）

## ファイルの説明および構成
このゲームでは、
1. enemy3：通常のボス
2. enemy6：レーザーを発射するボス
3. enemy4：自身の姿を消すボス
4. enemy5：プレイヤーを吹き飛ばす大砲を発射するボス
5. enemy1：自身のいるところに子機を生成するボス
6. enemy2：プレイヤーの弾を反射する鏡を持つボス
7. enemu7：プレイヤーの行動を錯乱させるボス
8. enemy8：ミサイルを射出しながら戦うボス
9. enemy9：目からビームを発射するボス
10. enemy10：ラスボス（左手から倒さないと復活する）
の順で敵が登場します。（順番とenemyの数字が合っていないのは開発工程で登場順を入れ替えたことが要因です。）


ソースコード含むゲーム開発に使用したデータはAssetsにあります。Assetsフォルダ下のフォルダは次のようになっています。
・Animations：ゲーム中のアニメーションファイルを格納しています。
・Prefabs：ゲームで使用するオブジェクトのまとまりを格納しています。（敵やプレイヤー、弾のデータなど）
・Scenes：ゲームのシーンを保存しています。
・Scripts：ゲーム制作に使用したソースコードを格納しています。
・Sounds：ゲームで使用する音声を格納しています。
・Sprites：ゲームで使用する画像などを格納しています。

## 備考
このゲームは高校生の時、文化祭で展示することを目的に制作しております。

BGM、ゲームで使用したイラストの一部は当時の部員からいただきました。残りのイラストは私の手書き、Web上のフリー素材を利用しております。

ソースコード、アニメーションなど、ゲームの動作に関わる部分はすべて私が担当しました。

セキュリティの観点から実行ファイルまでは添付しておりません。上記に示しておりますUnityの開発環境にて動作確認をすることが可能なはずです。

お問い合わせ先：maruteaso1083@gmail.com
