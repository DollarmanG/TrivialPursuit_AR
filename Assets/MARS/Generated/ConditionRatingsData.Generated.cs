// This file is automatically generated - DO NOT EDIT MANUALLY!
using System.Collections.Generic;
using Unity.XRTools.Utils;
using Unity.MARS.Query;

namespace Unity.MARS.Data
{
    partial class ConditionRatingsData
    {
        // used to map type to index in generated FromConditions method
        static int s_TypeIndex;

        public void FromConditions(ProxyConditions conditions)
        {
            m_Count = 0;
            s_TypeIndex = 0;
            var semanticTagLength = conditions.GetTypeCount(out ISemanticTagCondition[] semanticTagConditions);
            if(semanticTagLength > 0)
            {
                m_Count += semanticTagLength;
                TypeToIndex[typeof(System.Boolean)] = s_TypeIndex;
                var list = new List<Dictionary<int, float>>();
                list.Fill(semanticTagLength);
                AllRatings.Add(list);
                m_SemanticTagListIndex = s_TypeIndex;
                s_TypeIndex++;
            }

            var intLength = conditions.GetTypeCount(out ICondition<System.Int32>[] intConditions);
            if(intLength > 0)
            {
                m_Count += intLength;
                TypeToIndex[typeof(System.Int32)] = s_TypeIndex;
                var list = new List<Dictionary<int, float>>();
                list.Fill(intLength);
                AllRatings.Add(list);
                s_TypeIndex++;
            }

            var floatLength = conditions.GetTypeCount(out ICondition<System.Single>[] floatConditions);
            if(floatLength > 0)
            {
                m_Count += floatLength;
                TypeToIndex[typeof(System.Single)] = s_TypeIndex;
                var list = new List<Dictionary<int, float>>();
                list.Fill(floatLength);
                AllRatings.Add(list);
                s_TypeIndex++;
            }

            var stringLength = conditions.GetTypeCount(out ICondition<System.String>[] stringConditions);
            if(stringLength > 0)
            {
                m_Count += stringLength;
                TypeToIndex[typeof(System.String)] = s_TypeIndex;
                var list = new List<Dictionary<int, float>>();
                list.Fill(stringLength);
                AllRatings.Add(list);
                s_TypeIndex++;
            }

            var poseLength = conditions.GetTypeCount(out ICondition<UnityEngine.Pose>[] poseConditions);
            if(poseLength > 0)
            {
                m_Count += poseLength;
                TypeToIndex[typeof(UnityEngine.Pose)] = s_TypeIndex;
                var list = new List<Dictionary<int, float>>();
                list.Fill(poseLength);
                AllRatings.Add(list);
                s_TypeIndex++;
            }

            var vector2Length = conditions.GetTypeCount(out ICondition<UnityEngine.Vector2>[] vector2Conditions);
            if(vector2Length > 0)
            {
                m_Count += vector2Length;
                TypeToIndex[typeof(UnityEngine.Vector2)] = s_TypeIndex;
                var list = new List<Dictionary<int, float>>();
                list.Fill(vector2Length);
                AllRatings.Add(list);
                s_TypeIndex++;
            }
        }
    }
}
