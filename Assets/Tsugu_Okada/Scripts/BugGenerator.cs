using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  虫を生成するスクリプト
/// </summary>

public class BugGenerator : MonoBehaviour
{
    #region private Serialize

    // [SerializeField, Header("生成地")] GameObject _generatorObj;

    [SerializeField, Header("虫オブジェクト")] GameObject _bugObject;

    [SerializeField, Header("時間間隔の最小値")] float _minTime;

    [SerializeField,Header("時間間隔の最大値")] float _maxTime;

    #endregion

    #region private

    /// <summary> 虫生成時間間隔</summary>
    float _interval;

    /// <summary> 経過時間</summary>
    float _time;

    #endregion

    void Start()
    {
        // 時間間隔を決める
        _interval = GetRandomTime();
    }

    
    void Update()
    {
        // ここで計測開始
        _time += Time.deltaTime;


        // 生成時間を超えたら
        if (_time > _interval)
        {
            // 虫を生成
            GameObject bug = Instantiate(_bugObject,this.transform);


            //経過時間を初期化し、再計測
            _time = 0f;

            //次に発生する時間間隔を決める
            _interval = GetRandomTime();
        }
    }


    float GetRandomTime()
    {
        return Random.Range(_minTime, _maxTime);
    }


}
