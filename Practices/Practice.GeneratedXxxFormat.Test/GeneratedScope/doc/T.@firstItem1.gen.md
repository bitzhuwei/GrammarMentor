# 'firstItem1'

pattern: `<'['>\\u[0-9]{4}|\\t|\\n|\\r|\\-|[ -Z]|\[|\\\\|]|\\\^|[_-~]`

-------------------------------
# 1/5: extracted ε-NFA
```Mermaid
flowchart
classDef c0001 color:#FF0000;
classDef c0010 stroke-dasharray: 10 10;
classDef c0011 stroke-dasharray: 10 10,color:#FF0000;
classDef c0100 fill:#BB66EE;
classDef c0101 fill:#BB66EE,color:#FF0000;
classDef c0110 fill:#BB66EE,stroke-dasharray: 10 10;
classDef c0111 fill:#BB66EE,stroke-dasharray: 10 10,color:#FF0000;
classDef c1000 stroke:#333,stroke-width:4px;
classDef c1001 stroke:#333,stroke-width:4px,color:#FF0000;
classDef c1010 stroke:#333,stroke-width:4px,stroke-dasharray: 10 10;
classDef c1011 stroke:#333,stroke-width:4px,stroke-dasharray: 10 10,color:#FF0000;
classDef c1100 stroke:#333,stroke-width:4px,fill:#BB66EE;
classDef c1101 stroke:#333,stroke-width:4px,fill:#BB66EE,color:#FF0000;
classDef c1110 stroke:#333,stroke-width:4px,fill:#BB66EE,stroke-dasharray: 10 10;
classDef c1111 stroke:#333,stroke-width:4px,fill:#BB66EE,stroke-dasharray: 10 10,color:#FF0000;
eNFA1_9_29114861[["εNFA1-9 regex start"]]
eNFA1_0_9493525[["εNFA1-0 char{1, 1}"]]
eNFA1_11_60707159[["εNFA1-11 char{1, 1}"]]
eNFA1_15_18332862[["εNFA1-15 char{1, 1}"]]
eNFA1_19_30778037[["εNFA1-19 char{1, 1}"]]
eNFA1_23_8566882[["εNFA1-23 char{1, 1}"]]
eNFA1_27_9993078[["εNFA1-27 scope{1, 1}"]]
eNFA1_29_22828842[["εNFA1-29 char{1, 1}"]]
eNFA1_31_4132991[["εNFA1-31 char{1, 1}"]]
eNFA1_35_37196927[["εNFA1-35 char{1, 1}"]]
eNFA1_37_66336889[["εNFA1-37 char{1, 1}"]]
eNFA1_41_60161096[["εNFA1-41 scope{1, 1}"]]
eNFA1_1_15708245[["εNFA1-1 char[1]"]]
eNFA1_12_7156477[["εNFA1-12 char[1]"]]
eNFA1_16_64408298[["εNFA1-16 char[1]"]]
eNFA1_20_42803771[["εNFA1-20 char[1]"]]
eNFA1_24_49689627[["εNFA1-24 char[1]"]]
eNFA1_28_52288987[["εNFA1-28 scope[1]"]]
eNFA1_30_51184317[["εNFA1-30 char[1]"]]
eNFA1_32_44553466[["εNFA1-32 char[1]"]]
eNFA1_36_7549521[["εNFA1-36 char[1]"]]
eNFA1_38_65436882[["εNFA1-38 char[1]"]]
eNFA1_42_7531464[["εNFA1-42 scope[1]"]]
eNFA1_2_52061026[["εNFA1-2 char{1, 1}"]]
eNFA1_13_65896052[["εNFA1-13 char{1, 1}"]]
eNFA1_17_56193562[["εNFA1-17 char{1, 1}"]]
eNFA1_21_35980011[["εNFA1-21 char{1, 1}"]]
eNFA1_25_55384650[["εNFA1-25 char{1, 1}"]]
eNFA1_10_58005670[["εNFA1-10 regex end"]]
eNFA1_33_51302964[["εNFA1-33 char{1, 1}"]]
eNFA1_39_61899454[["εNFA1-39 char{1, 1}"]]
eNFA1_3_47799905[["εNFA1-3 char[1]"]]
eNFA1_14_54619558[["εNFA1-14 char[1]"]]
eNFA1_18_21813975[["εNFA1-18 char[1]"]]
eNFA1_22_62108053[["εNFA1-22 char[1]"]]
eNFA1_26_22101568[["εNFA1-26 char[1]"]]
eNFA1_43_27545963[["εNFA1-43 post-regex start"]]
eNFA1_34_64696385[["εNFA1-34 char[1]"]]
eNFA1_40_45396553[["εNFA1-40 char[1]"]]
eNFA1_4_46587076[["εNFA1-4 scope{4, 4}"]]
eNFA1_44_60814919[\"εNFA1-44 post-regex end"/]
eNFA1_5_42225780[["εNFA1-5 scope[1]"]]
eNFA1_6_44487706[["εNFA1-6 scope[2]"]]
eNFA1_7_64845042[["εNFA1-7 scope[3]"]]
eNFA1_8_17645916[["εNFA1-8 scope[4]"]]
eNFA1_9_29114861 -.->|"ε"|eNFA1_0_9493525
eNFA1_9_29114861 -.->|"ε"|eNFA1_11_60707159
eNFA1_9_29114861 -.->|"ε"|eNFA1_15_18332862
eNFA1_9_29114861 -.->|"ε"|eNFA1_19_30778037
eNFA1_9_29114861 -.->|"ε"|eNFA1_23_8566882
eNFA1_9_29114861 -.->|"ε"|eNFA1_27_9993078
eNFA1_9_29114861 -.->|"ε"|eNFA1_29_22828842
eNFA1_9_29114861 -.->|"ε"|eNFA1_31_4132991
eNFA1_9_29114861 -.->|"ε"|eNFA1_35_37196927
eNFA1_9_29114861 -.->|"ε"|eNFA1_37_66336889
eNFA1_9_29114861 -.->|"ε"|eNFA1_41_60161096
eNFA1_0_9493525 -->|"#92;"|eNFA1_1_15708245
eNFA1_11_60707159 -->|"#92;"|eNFA1_12_7156477
eNFA1_15_18332862 -->|"#92;"|eNFA1_16_64408298
eNFA1_19_30778037 -->|"#92;"|eNFA1_20_42803771
eNFA1_23_8566882 -->|"#92;"|eNFA1_24_49689627
eNFA1_27_9993078 -->|"[#32;-Z]"|eNFA1_28_52288987
eNFA1_29_22828842 -->|"["|eNFA1_30_51184317
eNFA1_31_4132991 -->|"#92;"|eNFA1_32_44553466
eNFA1_35_37196927 -->|"]"|eNFA1_36_7549521
eNFA1_37_66336889 -->|"#92;"|eNFA1_38_65436882
eNFA1_41_60161096 -->|"[_-~]"|eNFA1_42_7531464
eNFA1_1_15708245 -.->|"ε"|eNFA1_2_52061026
eNFA1_12_7156477 -.->|"ε"|eNFA1_13_65896052
eNFA1_16_64408298 -.->|"ε"|eNFA1_17_56193562
eNFA1_20_42803771 -.->|"ε"|eNFA1_21_35980011
eNFA1_24_49689627 -.->|"ε"|eNFA1_25_55384650
eNFA1_28_52288987 -.->|"ε"|eNFA1_10_58005670
eNFA1_30_51184317 -.->|"ε"|eNFA1_10_58005670
eNFA1_32_44553466 -.->|"ε"|eNFA1_33_51302964
eNFA1_36_7549521 -.->|"ε"|eNFA1_10_58005670
eNFA1_38_65436882 -.->|"ε"|eNFA1_39_61899454
eNFA1_42_7531464 -.->|"ε"|eNFA1_10_58005670
eNFA1_2_52061026 -->|"u"|eNFA1_3_47799905
eNFA1_13_65896052 -->|"t"|eNFA1_14_54619558
eNFA1_17_56193562 -->|"n"|eNFA1_18_21813975
eNFA1_21_35980011 -->|"r"|eNFA1_22_62108053
eNFA1_25_55384650 -->|"-"|eNFA1_26_22101568
eNFA1_10_58005670 -.->|"ε"|eNFA1_43_27545963
eNFA1_33_51302964 -->|"#92;"|eNFA1_34_64696385
eNFA1_39_61899454 -->|"^"|eNFA1_40_45396553
eNFA1_3_47799905 -.->|"ε"|eNFA1_4_46587076
eNFA1_14_54619558 -.->|"ε"|eNFA1_10_58005670
eNFA1_18_21813975 -.->|"ε"|eNFA1_10_58005670
eNFA1_22_62108053 -.->|"ε"|eNFA1_10_58005670
eNFA1_26_22101568 -.->|"ε"|eNFA1_10_58005670
eNFA1_43_27545963 -.->|"ε"|eNFA1_44_60814919
eNFA1_34_64696385 -.->|"ε"|eNFA1_10_58005670
eNFA1_40_45396553 -.->|"ε"|eNFA1_10_58005670
eNFA1_4_46587076 -->|"[0-9]"|eNFA1_5_42225780
eNFA1_5_42225780 -->|"[0-9]"|eNFA1_6_44487706
eNFA1_6_44487706 -->|"[0-9]"|eNFA1_7_64845042
eNFA1_7_64845042 -->|"[0-9]"|eNFA1_8_17645916
eNFA1_8_17645916 -.->|"ε"|eNFA1_10_58005670
```
-------------------------------
# 2/5: manifested ε-NFA
```Mermaid
flowchart
classDef c0001 color:#FF0000;
classDef c0010 stroke-dasharray: 10 10;
classDef c0011 stroke-dasharray: 10 10,color:#FF0000;
classDef c0100 fill:#BB66EE;
classDef c0101 fill:#BB66EE,color:#FF0000;
classDef c0110 fill:#BB66EE,stroke-dasharray: 10 10;
classDef c0111 fill:#BB66EE,stroke-dasharray: 10 10,color:#FF0000;
classDef c1000 stroke:#333,stroke-width:4px;
classDef c1001 stroke:#333,stroke-width:4px,color:#FF0000;
classDef c1010 stroke:#333,stroke-width:4px,stroke-dasharray: 10 10;
classDef c1011 stroke:#333,stroke-width:4px,stroke-dasharray: 10 10,color:#FF0000;
classDef c1100 stroke:#333,stroke-width:4px,fill:#BB66EE;
classDef c1101 stroke:#333,stroke-width:4px,fill:#BB66EE,color:#FF0000;
classDef c1110 stroke:#333,stroke-width:4px,fill:#BB66EE,stroke-dasharray: 10 10;
classDef c1111 stroke:#333,stroke-width:4px,fill:#BB66EE,stroke-dasharray: 10 10,color:#FF0000;
eNFA1_9_46079980[["εNFA1-9 regex start"]]
eNFA1_0_41490910[["εNFA1-0 char{1, 1}"]]
eNFA1_11_12066641[["εNFA1-11 char{1, 1}"]]
eNFA1_15_37873877[["εNFA1-15 char{1, 1}"]]
eNFA1_19_5320573[["εNFA1-19 char{1, 1}"]]
eNFA1_23_47885160[["εNFA1-23 char{1, 1}"]]
eNFA1_27_28313264[["εNFA1-27 scope{1, 1}"]]
eNFA1_29_53492789[["εNFA1-29 char{1, 1}"]]
eNFA1_31_11673056[["εNFA1-31 char{1, 1}"]]
eNFA1_35_37948642[["εNFA1-35 char{1, 1}"]]
eNFA1_37_5993460[["εNFA1-37 char{1, 1}"]]
eNFA1_41_53941143[["εNFA1-41 scope{1, 1}"]]
eNFA1_1_17957024[["εNFA1-1 char[1]"]]
eNFA1_12_45232806[["εNFA1-12 char[1]"]]
eNFA1_16_39978669[["εNFA1-16 char[1]"]]
eNFA1_20_17046748[["εNFA1-20 char[1]"]]
eNFA1_24_38609372[["εNFA1-24 char[1]"]]
eNFA1_28_42983031[\"εNFA1-28 scope[1]"/]
eNFA1_30_28699807[\"εNFA1-30 char[1]"/]
eNFA1_32_40351445[["εNFA1-32 char[1]"]]
eNFA1_36_59073500[\"εNFA1-36 char[1]"/]
eNFA1_38_47241582[["εNFA1-38 char[1]"]]
eNFA1_42_20224181[\"εNFA1-42 scope[1]"/]
eNFA1_2_27395488[["εNFA1-2 char{1, 1}"]]
eNFA1_3_12266058[["εNFA1-3 char[1]"]]
eNFA1_13_4442074[["εNFA1-13 char{1, 1}"]]
eNFA1_14_16630501[\"εNFA1-14 char[1]"/]
eNFA1_17_24263704[["εNFA1-17 char{1, 1}"]]
eNFA1_18_15456783[\"εNFA1-18 char[1]"/]
eNFA1_21_19203011[["εNFA1-21 char{1, 1}"]]
eNFA1_22_4893323[\"εNFA1-22 char[1]"/]
eNFA1_25_11940034[["εNFA1-25 char{1, 1}"]]
eNFA1_26_44039915[\"εNFA1-26 char[1]"/]
eNFA1_10_56971675[\"εNFA1-10 regex end"/]
eNFA1_43_1362895[\"εNFA1-43 post-regex start"/]
eNFA1_44_54026667[\"εNFA1-44 post-regex end"/]
eNFA1_33_27618686[["εNFA1-33 char{1, 1}"]]
eNFA1_34_10463359[\"εNFA1-34 char[1]"/]
eNFA1_39_22521054[["εNFA1-39 char{1, 1}"]]
eNFA1_40_27061374[\"εNFA1-40 char[1]"/]
eNFA1_4_43285665[["εNFA1-4 scope{4, 4}"]]
eNFA1_5_16477963[["εNFA1-5 scope[1]"]]
eNFA1_6_48487730[["εNFA1-6 scope[2]"]]
eNFA1_7_33736386[["εNFA1-7 scope[3]"]]
eNFA1_8_46734467[\"εNFA1-8 scope[4]"/]
eNFA1_9_46079980 -.->|"ε"|eNFA1_0_41490910
eNFA1_9_46079980 -.->|"ε"|eNFA1_11_12066641
eNFA1_9_46079980 -.->|"ε"|eNFA1_15_37873877
eNFA1_9_46079980 -.->|"ε"|eNFA1_19_5320573
eNFA1_9_46079980 -.->|"ε"|eNFA1_23_47885160
eNFA1_9_46079980 -.->|"ε"|eNFA1_27_28313264
eNFA1_9_46079980 -.->|"ε"|eNFA1_29_53492789
eNFA1_9_46079980 -.->|"ε"|eNFA1_31_11673056
eNFA1_9_46079980 -.->|"ε"|eNFA1_35_37948642
eNFA1_9_46079980 -.->|"ε"|eNFA1_37_5993460
eNFA1_9_46079980 -.->|"ε"|eNFA1_41_53941143
eNFA1_9_46079980 -->|"#92;"|eNFA1_1_17957024
eNFA1_9_46079980 -->|"#92;"|eNFA1_12_45232806
eNFA1_9_46079980 -->|"#92;"|eNFA1_16_39978669
eNFA1_9_46079980 -->|"#92;"|eNFA1_20_17046748
eNFA1_9_46079980 -->|"#92;"|eNFA1_24_38609372
eNFA1_9_46079980 -->|"[#32;-Z]"|eNFA1_28_42983031
eNFA1_9_46079980 -->|"["|eNFA1_30_28699807
eNFA1_9_46079980 -->|"#92;"|eNFA1_32_40351445
eNFA1_9_46079980 -->|"]"|eNFA1_36_59073500
eNFA1_9_46079980 -->|"#92;"|eNFA1_38_47241582
eNFA1_9_46079980 -->|"[_-~]"|eNFA1_42_20224181
eNFA1_0_41490910 -->|"#92;"|eNFA1_1_17957024
eNFA1_11_12066641 -->|"#92;"|eNFA1_12_45232806
eNFA1_15_37873877 -->|"#92;"|eNFA1_16_39978669
eNFA1_19_5320573 -->|"#92;"|eNFA1_20_17046748
eNFA1_23_47885160 -->|"#92;"|eNFA1_24_38609372
eNFA1_27_28313264 -->|"[#32;-Z]"|eNFA1_28_42983031
eNFA1_29_53492789 -->|"["|eNFA1_30_28699807
eNFA1_31_11673056 -->|"#92;"|eNFA1_32_40351445
eNFA1_35_37948642 -->|"]"|eNFA1_36_59073500
eNFA1_37_5993460 -->|"#92;"|eNFA1_38_47241582
eNFA1_41_53941143 -->|"[_-~]"|eNFA1_42_20224181
eNFA1_1_17957024 -.->|"ε"|eNFA1_2_27395488
eNFA1_1_17957024 -->|"u"|eNFA1_3_12266058
eNFA1_12_45232806 -.->|"ε"|eNFA1_13_4442074
eNFA1_12_45232806 -->|"t"|eNFA1_14_16630501
eNFA1_16_39978669 -.->|"ε"|eNFA1_17_24263704
eNFA1_16_39978669 -->|"n"|eNFA1_18_15456783
eNFA1_20_17046748 -.->|"ε"|eNFA1_21_19203011
eNFA1_20_17046748 -->|"r"|eNFA1_22_4893323
eNFA1_24_38609372 -.->|"ε"|eNFA1_25_11940034
eNFA1_24_38609372 -->|"-"|eNFA1_26_44039915
eNFA1_28_42983031 -.->|"ε"|eNFA1_10_56971675
eNFA1_28_42983031 -.->|"ε"|eNFA1_43_1362895
eNFA1_28_42983031 -.->|"ε"|eNFA1_44_54026667
eNFA1_30_28699807 -.->|"ε"|eNFA1_10_56971675
eNFA1_30_28699807 -.->|"ε"|eNFA1_43_1362895
eNFA1_30_28699807 -.->|"ε"|eNFA1_44_54026667
eNFA1_32_40351445 -.->|"ε"|eNFA1_33_27618686
eNFA1_32_40351445 -->|"#92;"|eNFA1_34_10463359
eNFA1_36_59073500 -.->|"ε"|eNFA1_10_56971675
eNFA1_36_59073500 -.->|"ε"|eNFA1_43_1362895
eNFA1_36_59073500 -.->|"ε"|eNFA1_44_54026667
eNFA1_38_47241582 -.->|"ε"|eNFA1_39_22521054
eNFA1_38_47241582 -->|"^"|eNFA1_40_27061374
eNFA1_42_20224181 -.->|"ε"|eNFA1_10_56971675
eNFA1_42_20224181 -.->|"ε"|eNFA1_43_1362895
eNFA1_42_20224181 -.->|"ε"|eNFA1_44_54026667
eNFA1_2_27395488 -->|"u"|eNFA1_3_12266058
eNFA1_3_12266058 -.->|"ε"|eNFA1_4_43285665
eNFA1_3_12266058 -->|"[0-9]"|eNFA1_5_16477963
eNFA1_13_4442074 -->|"t"|eNFA1_14_16630501
eNFA1_14_16630501 -.->|"ε"|eNFA1_10_56971675
eNFA1_14_16630501 -.->|"ε"|eNFA1_43_1362895
eNFA1_14_16630501 -.->|"ε"|eNFA1_44_54026667
eNFA1_17_24263704 -->|"n"|eNFA1_18_15456783
eNFA1_18_15456783 -.->|"ε"|eNFA1_10_56971675
eNFA1_18_15456783 -.->|"ε"|eNFA1_43_1362895
eNFA1_18_15456783 -.->|"ε"|eNFA1_44_54026667
eNFA1_21_19203011 -->|"r"|eNFA1_22_4893323
eNFA1_22_4893323 -.->|"ε"|eNFA1_10_56971675
eNFA1_22_4893323 -.->|"ε"|eNFA1_43_1362895
eNFA1_22_4893323 -.->|"ε"|eNFA1_44_54026667
eNFA1_25_11940034 -->|"-"|eNFA1_26_44039915
eNFA1_26_44039915 -.->|"ε"|eNFA1_10_56971675
eNFA1_26_44039915 -.->|"ε"|eNFA1_43_1362895
eNFA1_26_44039915 -.->|"ε"|eNFA1_44_54026667
eNFA1_10_56971675 -.->|"ε"|eNFA1_43_1362895
eNFA1_10_56971675 -.->|"ε"|eNFA1_44_54026667
eNFA1_43_1362895 -.->|"ε"|eNFA1_44_54026667
eNFA1_33_27618686 -->|"#92;"|eNFA1_34_10463359
eNFA1_34_10463359 -.->|"ε"|eNFA1_10_56971675
eNFA1_34_10463359 -.->|"ε"|eNFA1_43_1362895
eNFA1_34_10463359 -.->|"ε"|eNFA1_44_54026667
eNFA1_39_22521054 -->|"^"|eNFA1_40_27061374
eNFA1_40_27061374 -.->|"ε"|eNFA1_10_56971675
eNFA1_40_27061374 -.->|"ε"|eNFA1_43_1362895
eNFA1_40_27061374 -.->|"ε"|eNFA1_44_54026667
eNFA1_4_43285665 -->|"[0-9]"|eNFA1_5_16477963
eNFA1_5_16477963 -->|"[0-9]"|eNFA1_6_48487730
eNFA1_6_48487730 -->|"[0-9]"|eNFA1_7_33736386
eNFA1_7_33736386 -->|"[0-9]"|eNFA1_8_46734467
eNFA1_8_46734467 -.->|"ε"|eNFA1_10_56971675
eNFA1_8_46734467 -.->|"ε"|eNFA1_43_1362895
eNFA1_8_46734467 -.->|"ε"|eNFA1_44_54026667
```
-------------------------------
# 3/5: NFA
```Mermaid
flowchart
classDef c0001 color:#FF0000;
classDef c0010 stroke-dasharray: 10 10;
classDef c0011 stroke-dasharray: 10 10,color:#FF0000;
classDef c0100 fill:#BB66EE;
classDef c0101 fill:#BB66EE,color:#FF0000;
classDef c0110 fill:#BB66EE,stroke-dasharray: 10 10;
classDef c0111 fill:#BB66EE,stroke-dasharray: 10 10,color:#FF0000;
classDef c1000 stroke:#333,stroke-width:4px;
classDef c1001 stroke:#333,stroke-width:4px,color:#FF0000;
classDef c1010 stroke:#333,stroke-width:4px,stroke-dasharray: 10 10;
classDef c1011 stroke:#333,stroke-width:4px,stroke-dasharray: 10 10,color:#FF0000;
classDef c1100 stroke:#333,stroke-width:4px,fill:#BB66EE;
classDef c1101 stroke:#333,stroke-width:4px,fill:#BB66EE,color:#FF0000;
classDef c1110 stroke:#333,stroke-width:4px,fill:#BB66EE,stroke-dasharray: 10 10;
classDef c1111 stroke:#333,stroke-width:4px,fill:#BB66EE,stroke-dasharray: 10 10,color:#FF0000;
NFA1_9_14083945("NFA1-9 regex start")
NFA1_1_67057771("NFA1-1 char[1]")
NFA1_12_59646646("NFA1-12 char[1]")
NFA1_16_66649034("NFA1-16 char[1]")
NFA1_20_62970394("NFA1-20 char[1]")
NFA1_24_29862637("NFA1-24 char[1]")
NFA1_28_328285[\"NFA1-28 scope[1]"/]
NFA1_30_2954570[\"NFA1-30 char[1]"/]
NFA1_32_26591133("NFA1-32 char[1]")
NFA1_36_37993607[\"NFA1-36 char[1]"/]
NFA1_38_6398145("NFA1-38 char[1]")
NFA1_42_57583308[\"NFA1-42 scope[1]"/]
NFA1_3_35192023("NFA1-3 char[1]")
NFA1_14_48292752[\"NFA1-14 char[1]"/]
NFA1_18_31981592[\"NFA1-18 char[1]"/]
NFA1_22_19398879[\"NFA1-22 char[1]"/]
NFA1_26_40372191[\"NFA1-26 char[1]"/]
NFA1_34_27805399[\"NFA1-34 char[1]"/]
NFA1_40_48922001[\"NFA1-40 char[1]"/]
NFA1_5_37644831("NFA1-5 scope[1]")
NFA1_6_3259160("NFA1-6 scope[2]")
NFA1_7_29332447("NFA1-7 scope[3]")
NFA1_8_62665436[\"NFA1-8 scope[4]"/]
NFA1_9_14083945 -->|"#92;"|NFA1_1_67057771
NFA1_9_14083945 -->|"#92;"|NFA1_12_59646646
NFA1_9_14083945 -->|"#92;"|NFA1_16_66649034
NFA1_9_14083945 -->|"#92;"|NFA1_20_62970394
NFA1_9_14083945 -->|"#92;"|NFA1_24_29862637
NFA1_9_14083945 -->|"[#32;-Z]"|NFA1_28_328285
NFA1_9_14083945 -->|"["|NFA1_30_2954570
NFA1_9_14083945 -->|"#92;"|NFA1_32_26591133
NFA1_9_14083945 -->|"]"|NFA1_36_37993607
NFA1_9_14083945 -->|"#92;"|NFA1_38_6398145
NFA1_9_14083945 -->|"[_-~]"|NFA1_42_57583308
NFA1_1_67057771 -->|"u"|NFA1_3_35192023
NFA1_12_59646646 -->|"t"|NFA1_14_48292752
NFA1_16_66649034 -->|"n"|NFA1_18_31981592
NFA1_20_62970394 -->|"r"|NFA1_22_19398879
NFA1_24_29862637 -->|"-"|NFA1_26_40372191
NFA1_32_26591133 -->|"#92;"|NFA1_34_27805399
NFA1_38_6398145 -->|"^"|NFA1_40_48922001
NFA1_3_35192023 -->|"[0-9]"|NFA1_5_37644831
NFA1_5_37644831 -->|"[0-9]"|NFA1_6_3259160
NFA1_6_3259160 -->|"[0-9]"|NFA1_7_29332447
NFA1_7_29332447 -->|"[0-9]"|NFA1_8_62665436
```
-------------------------------
# 4/5: DFA
```Mermaid
flowchart
classDef c0001 color:#FF0000;
classDef c0010 stroke-dasharray: 10 10;
classDef c0011 stroke-dasharray: 10 10,color:#FF0000;
classDef c0100 fill:#BB66EE;
classDef c0101 fill:#BB66EE,color:#FF0000;
classDef c0110 fill:#BB66EE,stroke-dasharray: 10 10;
classDef c0111 fill:#BB66EE,stroke-dasharray: 10 10,color:#FF0000;
classDef c1000 stroke:#333,stroke-width:4px;
classDef c1001 stroke:#333,stroke-width:4px,color:#FF0000;
classDef c1010 stroke:#333,stroke-width:4px,stroke-dasharray: 10 10;
classDef c1011 stroke:#333,stroke-width:4px,stroke-dasharray: 10 10,color:#FF0000;
classDef c1100 stroke:#333,stroke-width:4px,fill:#BB66EE;
classDef c1101 stroke:#333,stroke-width:4px,fill:#BB66EE,color:#FF0000;
classDef c1110 stroke:#333,stroke-width:4px,fill:#BB66EE,stroke-dasharray: 10 10;
classDef c1111 stroke:#333,stroke-width:4px,fill:#BB66EE,stroke-dasharray: 10 10,color:#FF0000;
subgraph DFA0_-147513357["DFA0 regex start"]
NFA1_9_14083945_0("NFA1-9 regex start")
end
subgraph DFA1_-900978061["DFA1 {7}"]
NFA1_1_67057771_1("NFA1-1 char[1]")
NFA1_12_59646646_2("NFA1-12 char[1]")
NFA1_16_66649034_3("NFA1-16 char[1]")
NFA1_20_62970394_4("NFA1-20 char[1]")
NFA1_24_29862637_5("NFA1-24 char[1]")
NFA1_32_26591133_6("NFA1-32 char[1]")
NFA1_38_6398145_7("NFA1-38 char[1]")
end
subgraph DFA2_21445628["DFA2 {1}"]
NFA1_28_328285_8[\"NFA1-28 scope[1]"/]
end
subgraph DFA3_-301982084["DFA3 {1}"]
NFA1_30_2954570_9[\"NFA1-30 char[1]"/]
end
subgraph DFA4_-1745306937["DFA4 {1}"]
NFA1_36_37993607_10[\"NFA1-36 char[1]"/]
end
subgraph DFA5_-426637041["DFA5 {1}"]
NFA1_42_57583308_11[\"NFA1-42 scope[1]"/]
end
subgraph DFA6_-1468489949["DFA6 {1}"]
NFA1_3_35192023_12("NFA1-3 char[1]")
end
subgraph DFA7_983716186["DFA7 {1}"]
NFA1_14_48292752_13[\"NFA1-14 char[1]"/]
end
subgraph DFA8_789539251["DFA8 {1}"]
NFA1_18_31981592_14[\"NFA1-18 char[1]"/]
end
subgraph DFA9_-1716838635["DFA9 {1}"]
NFA1_22_19398879_15[\"NFA1-22 char[1]"/]
end
subgraph DFA10_-361620231["DFA10 {1}"]
NFA1_26_40372191_16[\"NFA1-26 char[1]"/]
end
subgraph DFA11_-1512994400["DFA11 {1}"]
NFA1_34_27805399_17[\"NFA1-34 char[1]"/]
end
subgraph DFA12_-1715323647["DFA12 {1}"]
NFA1_40_48922001_18[\"NFA1-40 char[1]"/]
end
subgraph DFA13_474445614["DFA13 {1}"]
NFA1_5_37644831_19("NFA1-5 scope[1]")
end
subgraph DFA14_-1314430007["DFA14 {1}"]
NFA1_6_3259160_20("NFA1-6 scope[2]")
end
subgraph DFA15_-1760297345["DFA15 {1}"]
NFA1_7_29332447_21("NFA1-7 scope[3]")
end
subgraph DFA16_938996287["DFA16 {1}"]
NFA1_8_62665436_22[\"NFA1-8 scope[4]"/]
end
DFA0_-147513357 -->|"#92;"|DFA1_-900978061
DFA0_-147513357 -->|"[#32;-Z]"|DFA2_21445628
DFA0_-147513357 -->|"["|DFA3_-301982084
DFA0_-147513357 -->|"]"|DFA4_-1745306937
DFA0_-147513357 -->|"[_-~]"|DFA5_-426637041
DFA1_-900978061 -->|"u"|DFA6_-1468489949
DFA1_-900978061 -->|"t"|DFA7_983716186
DFA1_-900978061 -->|"n"|DFA8_789539251
DFA1_-900978061 -->|"r"|DFA9_-1716838635
DFA1_-900978061 -->|"-"|DFA10_-361620231
DFA1_-900978061 -->|"#92;"|DFA11_-1512994400
DFA1_-900978061 -->|"^"|DFA12_-1715323647
DFA6_-1468489949 -->|"[0-9]"|DFA13_474445614
DFA13_474445614 -->|"[0-9]"|DFA14_-1314430007
DFA14_-1314430007 -->|"[0-9]"|DFA15_-1760297345
DFA15_-1760297345 -->|"[0-9]"|DFA16_938996287
```
-------------------------------
# 4/5: DFA.simple
```Mermaid
flowchart
classDef c0001 color:#FF0000;
classDef c0010 stroke-dasharray: 10 10;
classDef c0011 stroke-dasharray: 10 10,color:#FF0000;
classDef c0100 fill:#BB66EE;
classDef c0101 fill:#BB66EE,color:#FF0000;
classDef c0110 fill:#BB66EE,stroke-dasharray: 10 10;
classDef c0111 fill:#BB66EE,stroke-dasharray: 10 10,color:#FF0000;
classDef c1000 stroke:#333,stroke-width:4px;
classDef c1001 stroke:#333,stroke-width:4px,color:#FF0000;
classDef c1010 stroke:#333,stroke-width:4px,stroke-dasharray: 10 10;
classDef c1011 stroke:#333,stroke-width:4px,stroke-dasharray: 10 10,color:#FF0000;
classDef c1100 stroke:#333,stroke-width:4px,fill:#BB66EE;
classDef c1101 stroke:#333,stroke-width:4px,fill:#BB66EE,color:#FF0000;
classDef c1110 stroke:#333,stroke-width:4px,fill:#BB66EE,stroke-dasharray: 10 10;
classDef c1111 stroke:#333,stroke-width:4px,fill:#BB66EE,stroke-dasharray: 10 10,color:#FF0000;
DFA0_-147513357{{"DFA0 regex start"}}
DFA1_-900978061{{"DFA1 {7}"}}
DFA2_21445628[\"DFA2 {1}"/]
DFA3_-301982084[\"DFA3 {1}"/]
DFA4_-1745306937[\"DFA4 {1}"/]
DFA5_-426637041[\"DFA5 {1}"/]
DFA6_-1468489949{{"DFA6 {1}"}}
DFA7_983716186[\"DFA7 {1}"/]
DFA8_789539251[\"DFA8 {1}"/]
DFA9_-1716838635[\"DFA9 {1}"/]
DFA10_-361620231[\"DFA10 {1}"/]
DFA11_-1512994400[\"DFA11 {1}"/]
DFA12_-1715323647[\"DFA12 {1}"/]
DFA13_474445614{{"DFA13 {1}"}}
DFA14_-1314430007{{"DFA14 {1}"}}
DFA15_-1760297345{{"DFA15 {1}"}}
DFA16_938996287[\"DFA16 {1}"/]
DFA0_-147513357 -->|"#92;"|DFA1_-900978061
DFA0_-147513357 -->|"[#32;-Z]"|DFA2_21445628
DFA0_-147513357 -->|"["|DFA3_-301982084
DFA0_-147513357 -->|"]"|DFA4_-1745306937
DFA0_-147513357 -->|"[_-~]"|DFA5_-426637041
DFA1_-900978061 -->|"u"|DFA6_-1468489949
DFA1_-900978061 -->|"t"|DFA7_983716186
DFA1_-900978061 -->|"n"|DFA8_789539251
DFA1_-900978061 -->|"r"|DFA9_-1716838635
DFA1_-900978061 -->|"-"|DFA10_-361620231
DFA1_-900978061 -->|"#92;"|DFA11_-1512994400
DFA1_-900978061 -->|"^"|DFA12_-1715323647
DFA6_-1468489949 -->|"[0-9]"|DFA13_474445614
DFA13_474445614 -->|"[0-9]"|DFA14_-1314430007
DFA14_-1314430007 -->|"[0-9]"|DFA15_-1760297345
DFA15_-1760297345 -->|"[0-9]"|DFA16_938996287
```
-------------------------------
# 5/5: miniDFA
```Mermaid
flowchart
classDef c0001 color:#FF0000;
classDef c0010 stroke-dasharray: 10 10;
classDef c0011 stroke-dasharray: 10 10,color:#FF0000;
classDef c0100 fill:#BB66EE;
classDef c0101 fill:#BB66EE,color:#FF0000;
classDef c0110 fill:#BB66EE,stroke-dasharray: 10 10;
classDef c0111 fill:#BB66EE,stroke-dasharray: 10 10,color:#FF0000;
classDef c1000 stroke:#333,stroke-width:4px;
classDef c1001 stroke:#333,stroke-width:4px,color:#FF0000;
classDef c1010 stroke:#333,stroke-width:4px,stroke-dasharray: 10 10;
classDef c1011 stroke:#333,stroke-width:4px,stroke-dasharray: 10 10,color:#FF0000;
classDef c1100 stroke:#333,stroke-width:4px,fill:#BB66EE;
classDef c1101 stroke:#333,stroke-width:4px,fill:#BB66EE,color:#FF0000;
classDef c1110 stroke:#333,stroke-width:4px,fill:#BB66EE,stroke-dasharray: 10 10;
classDef c1111 stroke:#333,stroke-width:4px,fill:#BB66EE,stroke-dasharray: 10 10,color:#FF0000;
subgraph MiniDFA0_-1463255143["MiniDFA0 {1}"]
DFA0_-147513357_0{{"DFA0 regex start"}}
end
subgraph MiniDFA1_-1415109235["MiniDFA1 {1}"]
DFA1_-900978061_1{{"DFA1 {7}"}}
end
subgraph MiniDFA6_216238390["MiniDFA6 {1}"]
DFA2_21445628_2[\"DFA2 {1}"/]
end
subgraph MiniDFA7_-1431404338["MiniDFA7 {1}"]
DFA3_-301982084_3[\"DFA3 {1}"/]
end
subgraph MiniDFA8_962732498["MiniDFA8 {1}"]
DFA4_-1745306937_4[\"DFA4 {1}"/]
end
subgraph MiniDFA9_2553106["MiniDFA9 {1}"]
DFA5_-426637041_5[\"DFA5 {1}"/]
end
subgraph MiniDFA2_1407774947["MiniDFA2 {1}"]
DFA6_-1468489949_6{{"DFA6 {1}"}}
end
subgraph MiniDFA10_-324708326["MiniDFA10 {1}"]
DFA7_983716186_7[\"DFA7 {1}"/]
end
subgraph MiniDFA11_1021568885["MiniDFA11 {1}"]
DFA8_789539251_8[\"DFA8 {1}"/]
end
subgraph MiniDFA12_900919704["MiniDFA12 {1}"]
DFA9_-1716838635_9[\"DFA9 {1}"/]
end
subgraph MiniDFA13_1060939746["MiniDFA13 {1}"]
DFA10_-361620231_10[\"DFA10 {1}"/]
end
subgraph MiniDFA14_-285485385["MiniDFA14 {1}"]
DFA11_-1512994400_11[\"DFA11 {1}"/]
end
subgraph MiniDFA15_-1653651782["MiniDFA15 {1}"]
DFA12_-1715323647_12[\"DFA12 {1}"/]
end
subgraph MiniDFA3_1470076456["MiniDFA3 {1}"]
DFA13_474445614_13{{"DFA13 {1}"}}
end
subgraph MiniDFA4_-1499783465["MiniDFA4 {1}"]
DFA14_-1314430007_14{{"DFA14 {1}"}}
end
subgraph MiniDFA5_-1533892382["MiniDFA5 {1}"]
DFA15_-1760297345_15{{"DFA15 {1}"}}
end
subgraph MiniDFA16_-213591529["MiniDFA16 {1}"]
DFA16_938996287_16[\"DFA16 {1}"/]
end
MiniDFA0_-1463255143 -->|"#92;"|MiniDFA1_-1415109235
MiniDFA0_-1463255143 -->|"[#32;-Z]"|MiniDFA6_216238390
MiniDFA0_-1463255143 -->|"["|MiniDFA7_-1431404338
MiniDFA0_-1463255143 -->|"]"|MiniDFA8_962732498
MiniDFA0_-1463255143 -->|"[_-~]"|MiniDFA9_2553106
MiniDFA1_-1415109235 -->|"u"|MiniDFA2_1407774947
MiniDFA1_-1415109235 -->|"t"|MiniDFA10_-324708326
MiniDFA1_-1415109235 -->|"n"|MiniDFA11_1021568885
MiniDFA1_-1415109235 -->|"r"|MiniDFA12_900919704
MiniDFA1_-1415109235 -->|"-"|MiniDFA13_1060939746
MiniDFA1_-1415109235 -->|"#92;"|MiniDFA14_-285485385
MiniDFA1_-1415109235 -->|"^"|MiniDFA15_-1653651782
MiniDFA2_1407774947 -->|"[0-9]"|MiniDFA3_1470076456
MiniDFA3_1470076456 -->|"[0-9]"|MiniDFA4_-1499783465
MiniDFA4_-1499783465 -->|"[0-9]"|MiniDFA5_-1533892382
MiniDFA5_-1533892382 -->|"[0-9]"|MiniDFA16_-213591529
```
-------------------------------
# 5/5: miniDFA.simple
```Mermaid
flowchart
classDef c0001 color:#FF0000;
classDef c0010 stroke-dasharray: 10 10;
classDef c0011 stroke-dasharray: 10 10,color:#FF0000;
classDef c0100 fill:#BB66EE;
classDef c0101 fill:#BB66EE,color:#FF0000;
classDef c0110 fill:#BB66EE,stroke-dasharray: 10 10;
classDef c0111 fill:#BB66EE,stroke-dasharray: 10 10,color:#FF0000;
classDef c1000 stroke:#333,stroke-width:4px;
classDef c1001 stroke:#333,stroke-width:4px,color:#FF0000;
classDef c1010 stroke:#333,stroke-width:4px,stroke-dasharray: 10 10;
classDef c1011 stroke:#333,stroke-width:4px,stroke-dasharray: 10 10,color:#FF0000;
classDef c1100 stroke:#333,stroke-width:4px,fill:#BB66EE;
classDef c1101 stroke:#333,stroke-width:4px,fill:#BB66EE,color:#FF0000;
classDef c1110 stroke:#333,stroke-width:4px,fill:#BB66EE,stroke-dasharray: 10 10;
classDef c1111 stroke:#333,stroke-width:4px,fill:#BB66EE,stroke-dasharray: 10 10,color:#FF0000;
MiniDFA0_-1463255143(["MiniDFA0 {1}"])
MiniDFA1_-1415109235(["MiniDFA1 {1}"])
MiniDFA6_216238390[\"MiniDFA6 {1}"/]
MiniDFA7_-1431404338[\"MiniDFA7 {1}"/]
MiniDFA8_962732498[\"MiniDFA8 {1}"/]
MiniDFA9_2553106[\"MiniDFA9 {1}"/]
MiniDFA2_1407774947(["MiniDFA2 {1}"])
MiniDFA10_-324708326[\"MiniDFA10 {1}"/]
MiniDFA11_1021568885[\"MiniDFA11 {1}"/]
MiniDFA12_900919704[\"MiniDFA12 {1}"/]
MiniDFA13_1060939746[\"MiniDFA13 {1}"/]
MiniDFA14_-285485385[\"MiniDFA14 {1}"/]
MiniDFA15_-1653651782[\"MiniDFA15 {1}"/]
MiniDFA3_1470076456(["MiniDFA3 {1}"])
MiniDFA4_-1499783465(["MiniDFA4 {1}"])
MiniDFA5_-1533892382(["MiniDFA5 {1}"])
MiniDFA16_-213591529[\"MiniDFA16 {1}"/]
MiniDFA0_-1463255143 -->|"#92;"|MiniDFA1_-1415109235
MiniDFA0_-1463255143 -->|"[#32;-Z]"|MiniDFA6_216238390
MiniDFA0_-1463255143 -->|"["|MiniDFA7_-1431404338
MiniDFA0_-1463255143 -->|"]"|MiniDFA8_962732498
MiniDFA0_-1463255143 -->|"[_-~]"|MiniDFA9_2553106
MiniDFA1_-1415109235 -->|"u"|MiniDFA2_1407774947
MiniDFA1_-1415109235 -->|"t"|MiniDFA10_-324708326
MiniDFA1_-1415109235 -->|"n"|MiniDFA11_1021568885
MiniDFA1_-1415109235 -->|"r"|MiniDFA12_900919704
MiniDFA1_-1415109235 -->|"-"|MiniDFA13_1060939746
MiniDFA1_-1415109235 -->|"#92;"|MiniDFA14_-285485385
MiniDFA1_-1415109235 -->|"^"|MiniDFA15_-1653651782
MiniDFA2_1407774947 -->|"[0-9]"|MiniDFA3_1470076456
MiniDFA3_1470076456 -->|"[0-9]"|MiniDFA4_-1499783465
MiniDFA4_-1499783465 -->|"[0-9]"|MiniDFA5_-1533892382
MiniDFA5_-1533892382 -->|"[0-9]"|MiniDFA16_-213591529
```
-------------------------------
