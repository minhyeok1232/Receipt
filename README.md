# GOVR Manager Task

---

## 📖 목차

1. [🔎 프로젝트 소개](#-프로젝트-소개)  
2. [📅 개발 기간](#-개발-기간)  
3. [🧑‍💻 개발 환경 및 기술 스택](#-개발-환경-및-기술-스택)  
4. [📁 클래스 구조 및 설명](#-클래스-구조-및-설명)  
5. [💵 객체지향적 사고 관점 설명](#-객체지향적-사고-관점-설명)  
6. [📸 실행 화면](#-실행-화면)

---

## 🔎 프로젝트 소개

- 이 프로젝트는 GoVR커피 지점의 매니저가 마지막 날 업무를 마무리하며, 총 수익을 계산하고 20개 주문 내역에 대한 영수증을 출력하는 유니티 기반 과제입니다.
- C# 기반의 객체지향 설계를 바탕으로 `영수증`, `GOVR` 등 주요 클래스를 구현하여 각종 커피 주문, 가격 및 원가 데이터를 처리합니다.

---

## 📅 개발 기간

- 개발 기간 : 2025.05.16 ~ 2025.05.19  
- 제출 마감 : 2025.05.20 (화) 오전 10시  

---

## 🧑‍💻 개발 환경 및 기술 스택

- Language : C#  
- Engine : Unity 2022.3.42f1
- IDE : JetBrains Rider 2024.3
- Paradigm : 객체지향 프로그래밍 (OOP)  
- Platform : Windows  

---

## 📁 클래스 구조 및 설명
### 클래스 구조

<details>
  <summary> 클래스 구조 </summary>
    
<pre><code> 
  Assets/
  └── Scripts/
    ├── 1. Interfaces/
    │     └── IRandomProvider.cs
    ├── 2. Enums/
    │     └── PaymentType.cs
    ├── 3. Objects/
    │     ├── Coffee.cs
    │     └── Payment.cs
    ├── 4. Providers/
    │     ├── RandomCoffeeProvider.cs
    │     └── RandomPaymentProvider.cs
    └── 5. Systems/
    │     ├── GOVR.cs
    │     └── Receipts.cs </code></pre>

</details>

### 클래스 설명

<details>
  <summary> 클래스 설명 </summary>

### 1️⃣ Interface
#### IRandomProvider<T> 인터페이스 (1. Interfaces/IRandomProvider.cs)
- 랜덤 객체 생성 인터페이스

### 2️⃣ Enums
#### PaymentType 열거형 (2. Enums/PaymentType.cs)
- 결제 수단을 열거형으로 정의

### 3️⃣ Objects
#### Coffee 클래스 (3. Objects/Coffee.cs)
- 커피 객체를 정의
  
#### Payment 클래스 (3. Objects/Payment.cs)
- 결제 방식 정보를 담는 객체

### 4️⃣ Providers
#### RandomCoffeeProvider 클래스 (4. Providers/RandomCoffeeProvider.cs)
- 커피 객체 중 하나를 무작위로 반환

#### RandomPaymentProvider 클래스 (4. Providers/RandomPaymentProvider.cs)
- 무작위 결제 수단을 생성하여 반환

### 5️⃣ Systems
#### GOVR 클래스 (5. Systems/GOVR.cs)
- 커피 JSON(Newtonsoft) 데이터 로딩
- 각 오브젝트의(Coffee, Payment) 랜덤 메소드 반환 

#### Receipts 클래스 (5. Systems/Receipts.cs)
- 20회 주문을 수행
- 무작위 커피 및 결제 수단 생성
- 영수증 형태로 로그 출력
- 총 수익 계산

</details>

---

## 💵 객체지향적 사고 관점 설명
### 객체지향의 특징
<details>
  <summary> 객체지향의 특징 </summary>

### 1️⃣ `캡슐화'
![image](https://github.com/user-attachments/assets/ce5ac71e-5382-4258-b666-fdcf526bf01f)
- GOVR.cs에서 생성된 커피와 결제 정보는 Receipts.cs에서 읽기만 하도록 설계하였습니다.
- 외부(Receipts.cs)에서 객체의 상태가 변경되지 않도록 set을 private으로 제한하여 정보 은닉을 강화하였습니다.

### 2️⃣ `추상화`
![image](https://github.com/user-attachments/assets/9e11a619-8564-4dbb-aeea-ab813b84d38e)
- 각 오브젝트(Coffee, Payment)는 랜덤 생성 가능한 객체 라는 공통된 특성을 IRandomProvider<T>로 추상화하여, 동일한 방식으로 사용할 수 있도록 구조화하였습니다.

### 3️⃣ '상속성'
![image](https://github.com/user-attachments/assets/78265c06-519b-454e-844f-0d0202b8e590)
- RandomCoffeeProvider와 RandomPaymentProvider는 각각 IRandomProvider<T>를 상속한 구조로 구성하였습니다.

### 4️⃣ '다형성'
![image](https://github.com/user-attachments/assets/f69ccf9d-8e93-46e0-946c-6bb2bc69f004)
- 서로 다른 클래스를 동일한 방식(GetRandom())으로 사용할 수 있게 구성하였습니다.

</details>

### 객체지향의 원칙
<details>
  <summary> 객체지향의 원칙 </summary>

### 1️⃣ 단일 책임 원칙(SRP)
![image](https://github.com/user-attachments/assets/55eb2383-852d-4d78-8b58-717232df5b6b)
- 이외에도, 작성한 모든 클래스에서 하나의 기능만 담당하였습니다.

### 2️⃣ 개방-폐쇄 원칙(OCP)
![image](https://github.com/user-attachments/assets/78265c06-519b-454e-844f-0d0202b8e590)
- 새로운 오브젝트에 동일한 인터페이스 메소드(GetRandom)을 구현할 때, 클래스만 추가할 수 있도록 설계하였습니다.

### 3️⃣ 리스코프 치환 원칙(LSP)
![image](https://github.com/user-attachments/assets/7b3be15d-5d01-40d7-8be8-95128c287942)
- RandomCoffeeProvider, RandomPaymentProvider는 각각 부모 타입(IRandomProvider<T>)으로 치환하여 동작 할 수 있습니다.

### 4️⃣ 인터페이스 분리 원칙(ISP)
![image](https://github.com/user-attachments/assets/3a0bd01d-0f7f-49e8-8ee2-ffed456c0d64)
- 오브젝트들이 공통적으로 사용되는 필요한 기능만 제공하였습니다.

### 5️⃣ 의존 역전 원칙(DIP)
![image](https://github.com/user-attachments/assets/d067215b-4710-45dc-b46e-c789195f1ef1)
- coffeeProvider와 paymentProvider은 해당 Class에 직접 참조하지 않고 상위 요소인 인터페이스로 참조하여, 코드의 변화를 최소화 하였습니다. 

</details>

---

## 📸 실행 화면
![image](https://github.com/user-attachments/assets/8bf5289b-4b0c-4231-b103-6e762160c6b4)



---
