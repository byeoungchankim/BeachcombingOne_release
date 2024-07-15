# [Unity 3D] Beachcombing Game One
---


**1.소개**
---
![스크린샷 2024-06-12 133603](https://github.com/byeoungchankim/BeachcombingOne/assets/105476277/96fdf956-448f-48d6-a20e-81c4b570b013)
![스크린샷 2024-04-09 152825](https://github.com/byeoungchankim/BeachcombingOne/assets/105476277/34b7fa21-b82f-464e-b993-9194eb8109ed)
![스크린샷 2024-04-09 153526](https://github.com/byeoungchankim/BeachcombingOne/assets/105476277/7d19a0ce-43c5-4611-b964-b49cb7dcf67d)
                                       
< 게임 플레이 사진 >

* Unity 3D 캐주얼 게임입니다.
* 개발기간: 2024.03.03 ~ 2023.04.10 ( 약 1개월 )


**2.개발 환경**
---
* Unity 2021.3.35f1
* C#
* Window 11


**3.사용 기술**
---
|제목|설명|
|-----------|------------------------|
|디자인 패턴|싱글톤 패턴을 사용하여 Manager 관리|
|Object Pooling|자주 사용되는 객체는 Pool 관리하여 재사용|
|UI 자동화|유니티 UI 상에서 컴포넌트로 Drag&Drop되는 일을 줄이기 위한 편의성|

**4.사용 기술**
---
* Object
  * 캐릭터
     * 갈매기
     * 바다물범
     * 거북이
     * 돌고래
     * 초롱아귀
    
  * 쓰레기
    * 과자 비닐
    * 비닐봉투
    * 세제통
    * 캔
    * 유리병
   
  * 아이템
    * 핑크 산호초
    * 노랑 산호초
    * 초록 산호초
    
* UI
 * Scene:
   *  TitleScene : 게임 접속 시 사용
      ( 게임 시작 버튼 )
 * WorldSpace:
    * 쓰레기 수거 Effect, 쓰레기 게이지 Bar, 체력 Bar, 타이머

