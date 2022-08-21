using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  ���𐶐�����X�N���v�g
/// </summary>

public class BugGenerator : MonoBehaviour
{
    #region private Serialize

    // [SerializeField, Header("�����n")] GameObject _generatorObj;

    [SerializeField, Header("���I�u�W�F�N�g")] GameObject _bugObject;

    [SerializeField, Header("���ԊԊu�̍ŏ��l")] float _minTime;

    [SerializeField,Header("���ԊԊu�̍ő�l")] float _maxTime;

    #endregion

    #region private

    /// <summary> ���������ԊԊu</summary>
    float _interval;

    /// <summary> �o�ߎ���</summary>
    float _time;

    #endregion

    void Start()
    {
        // ���ԊԊu�����߂�
        _interval = GetRandomTime();
    }

    
    void Update()
    {
        // �����Ōv���J�n
        _time += Time.deltaTime;


        // �������Ԃ𒴂�����
        if (_time > _interval)
        {
            // ���𐶐�
            GameObject bug = Instantiate(_bugObject,this.transform);


            //�o�ߎ��Ԃ����������A�Čv��
            _time = 0f;

            //���ɔ������鎞�ԊԊu�����߂�
            _interval = GetRandomTime();
        }
    }


    float GetRandomTime()
    {
        return Random.Range(_minTime, _maxTime);
    }


}
