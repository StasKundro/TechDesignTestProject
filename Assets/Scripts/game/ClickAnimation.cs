using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAnimation : MonoBehaviour
{
    private Animator animator;
    public string animationTrigger = "Play"; // �������� �������� � ���������
    private AudioSource audioSource; // �������� �����
    public ParticleSystem particleS; // ������ ������
    private Rigidbody2D rb;
    public float jumpForce = 5f; // ���� �������������

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void OnMouseDown()
    {
        if (animator != null)
        {
            animator.SetTrigger(animationTrigger);
        }

        if (audioSource != null)
        {
            audioSource.Play();
        }

        if (particleS != null)
        {
            particleS.Play();
        }

        if (rb != null)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
}
