# Secrets:
## KEYSTORE_FILE
Это `*.keystore` файл который был создан vs2022 (обычно при первой попытке распространения приложения)

Найти его можно здесь:
`C:\Users\username\AppData\Local\Xamarin\Mono for Android\Keystore\`

Но в секрет запихать файл нельзя, но можно превратить файл в строку, для этого есть base64.
В данном тестовом проекте этот файл превращается в base64 с помощью алгоритма шифрования openGPG или просто GPG.

Применяем консольную команду (предварительно перейдя в директорию где лежит кейстор)

`gpg -c --armor test_wf.keystore`

(Если нет этой консольной утилиты, то скачай его в гугле openGPG или типа того)

В будущем попробую использовать обычное преобразование файла `*.keystore` в base64, т.к. считаю странным пихать в секрет -> секрет. Плюс это уменьшит количество лишних секретов.

## KEYSTORE_PASSWORD
Это пароль который мы вводим каждый раз при расспростарении релизной апкашки

![image](https://github.com/scriptBoris/MauiTestWorkflow/assets/29772096/a9a6e59a-df38-4e51-8d0b-596eb9cc1b14)

## KEYSTORE_PASSWORD_ALIAS
Это название ключа (он же АЛИАС) 

![image](https://github.com/scriptBoris/MauiTestWorkflow/assets/29772096/0a1b97d0-7365-420d-a065-42ed1b1b2065)

## KEYSTORE_PASSWORD_GPG
Это пароль когда мы преобразовывали алгоритмом GPG файл `*.keystore` в base64 и пихали его секрет выше

![image](https://github.com/scriptBoris/MauiTestWorkflow/assets/29772096/981446a8-8f97-45e8-bce3-f920bcd1b897)
