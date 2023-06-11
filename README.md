# GS25ManagementApp
객체지향프로그래밍  기말과제 프로젝트

GS25 Management App은 GS25 근무자의 편의성을 위한 애플리케이션입니다. 이 앱은 C# WinForms를 사용하여 구현되었으며, 매장 운영에 필요한 다양한 기능을 제공합니다.

## 주요 기능
-로그인 기능: 사용자가 계정으로 로그인하여 애플리케이션에 접근할 수 있습니다. (DB에 저장되어있는 worker Table의 아이디와 비밀번호가 일치하면 로그인)
<p align="center">
  <img src="https://github.com/ks2019975070/GS25ManagementApp/assets/48702307/405871f4-04b4-45d4-b431-1b0c2eac87a4">
</p>
-비밀번호를 잊어버리셨습니까? 텍스트를 누르면 이름과 휴대폰 번호를 통해 비밀번호를 찾을 수 있습니다.
<p align="center">
  <img src="https://github.com/ks2019975070/GS25ManagementApp/assets/48702307/c41987e1-4367-45e5-9164-4f7a61dfdb40">
</p>

- 회원가입 기능: 새로운 사용자를 등록하고 애플리케이션에 회원으로 추가합니다. (단, 아이디가 중복된다면 회원가입 되지않음)
<p align="center">
  <img src="https://github.com/ks2019975070/GS25ManagementApp/assets/48702307/8f8afbe3-3476-4fa5-988d-bea2eee749b8">
</p>

- 근무사항 기능: 근무자의 근무 일정을 확인하고 관리할 수 있습니다. (오전과 오후로 나누어짐)
<p align="center">
  <img src="https://github.com/ks2019975070/GS25ManagementApp/assets/48702307/fec18324-f498-486a-a9bd-b3aee08bf526">
</p>

- 전달사항 기능: 매장 내부에서 직원들끼리 전달해야 할 메시지를 작성하고 확인할 수 있습니다. 
  오래 된 전달사항이라면 날짜를 확인하여 삭제도 가능합니다.
<p align="center">
  <img src="https://github.com/ks2019975070/GS25ManagementApp/assets/48702307/9a96cdf6-1113-485a-aa9e-a344d0f10fab">
</p>

- 근무자 스케줄 기능: 근무자의 스케줄을 확인할 수 있습니다.
  왼쪽에 캘린더에는 근무하는 날짜를 Bold 표시 해놓았고 오른쪽 list view에는 근무자의 근무타입을 조회해 현재 날짜를 기준으로 이번 달 근무날짜,근무시작시간,종료시간을 표기하여 줍니다.
<p align="center">
  <img src="https://github.com/ks2019975070/GS25ManagementApp/assets/48702307/55e7d32d-5966-475f-a11f-10eaf05fac26">
</p>

- 행사 상품 확인 기능: 행사 중인 상품들을 확인하고 관리합니다.
  프로모션 필터를 통해 특정한 행사 프로모션들만 분류하여 볼 수 있고, 검색을 통해 특정 상품의 행사를 확인 할 수 있습니다.
<p align="center">
  <img src="https://github.com/ks2019975070/GS25ManagementApp/assets/48702307/8f13515d-f163-418a-adf8-2ee0a903b031">
</p>

- 유통기한 체크 기능: 상품의 유통기한을 체크할 수 있으며 필터와 검색을 통해 상품의 유통기한을 조회할 수 있고 추가도 가능합니다.
<p align="center">
  <img src="https://github.com/ks2019975070/GS25ManagementApp/assets/48702307/01fd893c-6470-41fe-8a87-f599b07931b3">
</p>

- 급여 계산기 기능:  근무자의 근무 타입에 따라 자동으로 현재 날짜를 기준으로 이번 달 급여를 계산합니다.
<p align="center">
  <img src="https://github.com/ks2019975070/GS25ManagementApp/assets/48702307/6557d55d-5b6c-4bf8-9c9f-d9b9c9229961">
</p>

- 근무자 정보 관리 기능: 근무자의 개인 정보를 확인하고 수정이 가능합니다.
<p align="center">
  <img src="https://github.com/ks2019975070/GS25ManagementApp/assets/48702307/0376e79e-d454-48cd-a0f7-da0e19ca7c92">
</p>
-근무자 정보 수정 화면은 회원가입 화면과 동일하지만 기존에 있던 데이터를 업데이트 하는 방식입니다.
<p align="center">
  <img src="https://github.com/ks2019975070/GS25ManagementApp/assets/48702307/5e54f168-f863-48c1-ae2c-e90c939ff773">
</p>

- POS기 기능: 상품 판매, 결제, 판매내역 조회 등의 기능을 제공하는 POS 시스템을 포함합니다.
  상품명 수량,가격을 입력해야지만 담기 버튼이 실행되도록 하였고, 담기 버튼을 누르면 쇼핑목록에 상품이 추가됩니다. (만약 같은 상품명이 쇼핑리스트에 있다면 수량만 증가합니다)
  수량변경을 하려면 상품의 행을 선택하고 수량 값을 설정한뒤 수량변경 버튼을 누르면 자동으로 수량이 변경됩니다.
  자주 팔리는 물건들은 아이템 버튼을 따로 만들어주어 클릭시 자동으로 쇼핑 리스트에 추가 되게끔 만들었고 행을 선택하고 취소를 누르면 
  쇼핑 목록에서 제외 됩니다. 
  지불 가격은 자동으로 계산되어 물건이 업데이트 될때마다 값이 변경됩니다.
  결제 버튼을 누르면 쇼핑리스트와 지불 가격 총합이 초기화 되고 판매한 상품들은 판매내역 테이블에 저장됩니다.
<p align="center">
  <img src="https://github.com/ks2019975070/GS25ManagementApp/assets/48702307/496296f9-5376-4177-9028-335b02f98d78">
</p>
-지금까지 판매했던 상품들의 정보들을 모아둔 테이블의 내용을 볼수 있도록 합니다.
<p align="center">
  <img src="https://github.com/ks2019975070/GS25ManagementApp/assets/48702307/296ef9a9-3b9f-47c2-ad93-0262df88a9c8">
</p>

## 사용 기술 및 도구

- C# WinForms: 사용자 인터페이스를 구현하기 위해 C# WinForms 프레임워크를 사용했습니다.
- MySQL: 데이터베이스로 MySQL을 사용하여 상품 정보, 주문 정보, 직원 정보 등을 저장하고 관리합니다.
- OpenWeatherAPI: 외부 API인 OpenWeatherAPI를 활용하여 날씨 정보를 조회하고 표시합니다.

## 시스템 요구사항

- Windows 운영체제 (Windows 7 이상)
- .NET Framework 4.5 이상 설치

## 설치 및 실행 방법

1. 이 저장소를 클론하거나 다운로드하여 로컬 환경에 프로젝트를 가져옵니다.
2. Visual Studio 또는 유사한 C# 개발 환경을 사용하여 프로젝트를 엽니다.
3. 프로젝트를 빌드하여 실행 가능한 애플리케이션을 생성합니다.
4. 생성된 애플리케이션을 실행하여 GS25 Management App을 사용합니다.

## 개발자 정보

- 이름: 한재훈
- 이메일: hjh7708@gmail.com
- GitHub: [[GitHub 프로필 링크]](https://github.com/ks2019975070)
