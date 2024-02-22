# Secrets:
## KEYSTORE_FILE_BASE64
Это `*.keystore` файл который был создан vs2022 (обычно при первой попытке распространения приложения)

Найти его можно здесь:
`C:\Users\username\AppData\Local\Xamarin\Mono for Android\Keystore\`

Но в секрет запихать файл нельзя, но можно превратить файл в строку, для этого есть base64.

В данном проекте, значение данного секрета:
```
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
```

## KEYSTORE_PASSWORD
Это пароль хранилища ключей, конкретно файла `*.keystore`. 

По сути файл `*.keystore` это контейнер, который хранит в себе ключи. И каждый ключ имеет свой пароль для открытия. 

Через внешние утилиты, в процессе создания `keystore` (например keytool.exe) можно указать разный пароль для `keystore` и для ключа (он же `alias`).

Но в нашем C# случае наша среда Visual Studio 2022, при создании `keystore` и вводе пароля - создает одинаковые пароли как на `keystore` так и на ключ (он же `alias`)

На скриншоте ниже пример когда мы создаем пароль

![image](https://github.com/scriptBoris/MauiTestWorkflow/assets/29772096/a9a6e59a-df38-4e51-8d0b-596eb9cc1b14)

Или когда Visual Studio 2022 просит ввести пароль, каждый раз, когда мы вручную расспространяем релизную .apk

![image](https://github.com/scriptBoris/MauiTestWorkflow/assets/29772096/80981187-0522-40b2-8b8e-4d05fd8cde6b)

Значение данного секрета: `123456`

## KEYSTORE_ALIAS
Это название ключа (он же АЛИАС) 

![image](https://github.com/scriptBoris/MauiTestWorkflow/assets/29772096/0a1b97d0-7365-420d-a065-42ed1b1b2065)

Значение данного секрета: `test_wf`
